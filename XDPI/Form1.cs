using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace XDPI
{
    public partial class Form1 : Form
    {
        private string savepath = "";
        private string prepath = "";
        private string[] paths = { "-ldpi", "-mdpi", "-hdpi", "-xhdpi", "-xxhdpi", "-xxxhdpi" };
        private double[] rates = { 0.75, 1, 1.5, 2, 3, 4 };
        private Dictionary<string, double> d = new Dictionary<string, double>();
        public Form1()
        {
            InitializeComponent();
            progressBar1.Hide();
            savepath = AppDomain.CurrentDomain.BaseDirectory + "temp";
            tbpath.Text = savepath;
            filedlg.Multiselect = true;
            filedlg.Filter = "png|*.png|jpg|*.jpg|bmp|*.bmp";
            for (int i = 0; i < rates.Length; i++)
            {
                if (paths[i] != paths[0] && paths[i] != paths[5])
                {
                    d.Add(paths[i], rates[i]);
                }
            }
        }

        //添加图片
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (filedlg.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < filedlg.FileNames.Length; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    //图片
                    Image img = Image.FromFile(filedlg.FileNames[i]);
                    DataGridViewImageCell imgc = new DataGridViewImageCell();
                    imgc.Value = img.Clone();
                    imgc.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imgc.ToolTipText = "双击查看大图";
                    row.Cells.Add(imgc);
                    //路径
                    DataGridViewTextBoxCell path = new DataGridViewTextBoxCell();
                    path.Value = filedlg.FileNames[i];
                    row.Cells.Add(path);
                    //文件名
                    DataGridViewTextBoxCell name = new DataGridViewTextBoxCell();
                    name.Value = Path.GetFileNameWithoutExtension(filedlg.FileNames[i]);
                    row.Cells.Add(name);
                    //像素
                    DataGridViewTextBoxCell px = new DataGridViewTextBoxCell();
                    px.Value = img.Width + "X" + img.Height;
                    row.Cells.Add(px);
                    //分辨率
                    DataGridViewTextBoxCell deep = new DataGridViewTextBoxCell();
                    deep.Value = img.HorizontalResolution + "X" + img.VerticalResolution;
                    row.Cells.Add(deep);
                    gvImg.Rows.Add(row);
                    img.Dispose();
                }
            }
        }

        //选择存放路径
        private void btnpath_Click(object sender, EventArgs e)
        {
            if (folderdlg.ShowDialog() == DialogResult.OK)
            {
                savepath = folderdlg.SelectedPath;
                tbpath.Text = savepath;
            }
        }
        //转换
        private void btntran_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = d.Count * (gvImg.Rows.Count - 1);
            progressBar1.Value = 0;
            progressBar1.Show();
            //保存路径
            prepath = tbpname.Text;
            d.OrderBy(t => t.Key);
            double rate = d.Last().Value;
            for (int r = 0; r < gvImg.Rows.Count - 1; r++)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string key in d.Keys)
                {
                    Bitmap oldbmp = new Bitmap(gvImg.Rows[r].Cells[1].Value.ToString());
                    string temp = savepath + "\\" + prepath + key;
                    if (!Directory.Exists(temp))
                    {
                        Directory.CreateDirectory(temp);
                    }
                    string fp = temp + "\\" + gvImg.Rows[r].Cells[2].Value.ToString() + Path.GetExtension(gvImg.Rows[r].Cells[1].Value.ToString());
                    if (!File.Exists(fp))
                    {
                        if (d[key] == rate)
                        {
                            File.Copy(gvImg.Rows[r].Cells[1].Value.ToString(), fp);
                        }
                        else
                        {
                            Bitmap bmp = GetThumbnail(oldbmp, d[key] / rate);
                            bmp.Save(fp);
                            bmp.Dispose();
                        }
                    }
                    else
                    {
                        sb.Append(prepath + key + ",");
                    }
                    oldbmp.Dispose();

                }
                if (sb.ToString().Length > 0)
                {
                    gvImg.Rows[r].Cells[5].Value = "已存在导致的失败：" + sb.ToString().TrimEnd(',');
                }
                else
                {
                    gvImg.Rows[r].Cells[5].Value = "成功";
                }
            }
            progressBar1.Hide();

        }

        public static Bitmap GetThumbnail(Image img, double rate)
        {
            // 按比例缩放
            int sWidth = img.Width;
            int sHeight = img.Height;
            double sW = sWidth * rate;
            double sH = sHeight * rate;
            Bitmap outBmp = new Bitmap((int)sW, (int)sH);
            Graphics g = Graphics.FromImage(outBmp);
            g.Clear(Color.Transparent);
            // 设置画布的描绘质量         
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, new Rectangle(0, 0, (int)sW, (int)sH), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel);
            g.Dispose();
            // 以下代码为保存图片时，设置压缩质量     
            EncoderParameters encoderParams = new EncoderParameters();
            long[] quality = new long[1];
            quality[0] = 100;
            EncoderParameter encoderParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            encoderParams.Param[0] = encoderParam;
            img.Dispose();
            return outBmp;
        }
        //双击查看图片
        private void gvImg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //点击的是第一个单元格
            if (e.ColumnIndex == 0 && e.RowIndex != gvImg.Rows.Count - 1)
            {
                pictureBox1.ImageLocation = gvImg.Rows[e.RowIndex].Cells[1].Value.ToString();
                pictureBox1.Show();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            //获取拖入的数据
            if (e.Data.GetDataPresent(DataFormats.FileDrop))//判断拖进来是不是文件类型的
            {
                //取出文件数组(保存在files数组中)
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                for (int i = 0; i < files.Length; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    //图片
                    Image img = Image.FromFile(files[i]);
                    DataGridViewImageCell imgc = new DataGridViewImageCell();
                    imgc.Value = img.Clone();
                    imgc.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imgc.ToolTipText = "双击查看大图";
                    row.Cells.Add(imgc);
                    //路径
                    DataGridViewTextBoxCell path = new DataGridViewTextBoxCell();
                    path.Value = files[i];
                    row.Cells.Add(path);
                    //文件名
                    DataGridViewTextBoxCell name = new DataGridViewTextBoxCell();
                    name.Value = Path.GetFileNameWithoutExtension(files[i]);
                    row.Cells.Add(name);
                    //像素
                    DataGridViewTextBoxCell px = new DataGridViewTextBoxCell();
                    px.Value = img.Width + "X" + img.Height;
                    row.Cells.Add(px);
                    //分辨率
                    DataGridViewTextBoxCell deep = new DataGridViewTextBoxCell();
                    deep.Value = img.HorizontalResolution + "X" + img.VerticalResolution;
                    row.Cells.Add(deep);
                    gvImg.Rows.Add(row);
                    img.Dispose();
                }
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void lhpi_CheckedChanged(object sender, EventArgs e)
        {
            //选中
            if (lhpi.Checked)
            {
                if (!d.ContainsKey(paths[0]))
                {
                    d.Add(paths[0], rates[0]);
                }
            }
            else//取消选中
            {
                if (d.ContainsKey(paths[0]))
                {
                    d.Remove(paths[0]);
                }
            }
        }

        private void mdpi_CheckedChanged(object sender, EventArgs e)
        {
            //选中
            if (mdpi.Checked)
            {
                if (!d.ContainsKey(paths[1]))
                {
                    d.Add(paths[1], rates[1]);
                }
            }
            else//取消选中
            {
                if (d.ContainsKey(paths[1]))
                {
                    d.Remove(paths[1]);
                }
            }
        }

        private void hdpi_CheckedChanged(object sender, EventArgs e)
        {
            //选中
            if (hdpi.Checked)
            {
                if (!d.ContainsKey(paths[2]))
                {
                    d.Add(paths[2], rates[2]);
                }
            }
            else//取消选中
            {
                if (d.ContainsKey(paths[2]))
                {
                    d.Remove(paths[2]);
                }
            }
        }

        private void xhdpi_CheckedChanged(object sender, EventArgs e)
        {
            //选中
            if (xhdpi.Checked)
            {
                if (!d.ContainsKey(paths[3]))
                {
                    d.Add(paths[3], rates[3]);
                }
            }
            else//取消选中
            {
                if (d.ContainsKey(paths[3]))
                {
                    d.Remove(paths[3]);
                }
            }
        }

        private void xxhdpi_CheckedChanged(object sender, EventArgs e)
        {
            //选中
            if (xxhdpi.Checked)
            {
                if (!d.ContainsKey(paths[4]))
                {
                    d.Add(paths[4], rates[4]);
                }
            }
            else//取消选中
            {
                if (d.ContainsKey(paths[4]))
                {
                    d.Remove(paths[4]);
                }
            }
        }

        private void xxxhdpi_CheckedChanged(object sender, EventArgs e)
        {
            //选中
            if (xxxhdpi.Checked)
            {
                if (!d.ContainsKey(paths[5]))
                {
                    d.Add(paths[5], rates[5]);
                }
            }
            else//取消选中
            {
                if (d.ContainsKey(paths[5]))
                {
                    d.Remove(paths[5]);
                }
            }
        }
    }
}
