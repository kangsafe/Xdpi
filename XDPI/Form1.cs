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
        private string[] paths = { "-xxxhdpi", "-xxhdpi", "-xhdpi", "-hdpi", "-mdpi", "-ldpi" };
        private double[] rates = { 4, 3, 2, 1.5, 1, 0.75 };
        public Form1()
        {
            InitializeComponent();
            progressBar1.Hide();
            savepath = AppDomain.CurrentDomain.BaseDirectory + "temp";
            tbpath.Text = savepath;
            filedlg.Multiselect = true;
            filedlg.Filter = "png|*.png|jpg|*.jpg|bmp|*.bmp";
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
                    imgc.Value = img;
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
            progressBar1.Maximum = paths.Length * (gvImg.Rows.Count - 1);
            progressBar1.Value = 0;
            progressBar1.Show();
            //保存路径
            prepath = tbpname.Text;
            for (int r = 0; r < gvImg.Rows.Count - 1; r++)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < paths.Length; i++)
                {
                    progressBar1.Value = r * paths.Length + i + 1;
                    Bitmap oldbmp = new Bitmap(gvImg.Rows[r].Cells[1].Value.ToString());
                    string temp = savepath + "\\" + prepath + paths[i];
                    if (!Directory.Exists(temp))
                    {
                        Directory.CreateDirectory(temp);
                    }
                    string fp = temp + "\\" + gvImg.Rows[r].Cells[2].Value.ToString() + Path.GetExtension(gvImg.Rows[r].Cells[1].Value.ToString());
                    if (!File.Exists(fp))
                    {
                        if (i == 0)
                        {
                            File.Copy(gvImg.Rows[r].Cells[1].Value.ToString(), fp);
                        }
                        else
                        {
                            Bitmap bmp = GetThumbnail(oldbmp, rates[i] / rates[0]);
                            bmp.Save(fp);
                            bmp.Dispose();
                        }
                    }
                    else
                    {
                        sb.Append(prepath + paths[i] + ",");
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
                    imgc.Value = img;
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
                }                                                          //如果有多个文件,files[0]就是第一个文件的路径了
                //richTextBox1.Text = System.IO.File.ReadAllText(files[0]);//IO操作读入文本内容
            }
            //Cursor = Cursors.NoMove2D;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            ////获取拖入的数据
            //if (e.Data.GetDataPresent(DataFormats.FileDrop))//判断拖进来是不是文件类型的
            //{
            //    //取出文件数组(保存在files数组中)
            //    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //    for (int i = 0; i < files.Length; i++)
            //    {
            //        DataGridViewRow row = new DataGridViewRow();
            //        //图片
            //        Image img = Image.FromFile(files[i]);
            //        DataGridViewImageCell imgc = new DataGridViewImageCell();
            //        imgc.Value = img;
            //        imgc.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //        imgc.ToolTipText = "双击查看大图";
            //        row.Cells.Add(imgc);
            //        //路径
            //        DataGridViewTextBoxCell path = new DataGridViewTextBoxCell();
            //        path.Value = files[i];
            //        row.Cells.Add(path);
            //        //文件名
            //        DataGridViewTextBoxCell name = new DataGridViewTextBoxCell();
            //        name.Value = Path.GetFileNameWithoutExtension(files[i]);
            //        row.Cells.Add(name);
            //        //像素
            //        DataGridViewTextBoxCell px = new DataGridViewTextBoxCell();
            //        px.Value = img.Width + "X" + img.Height;
            //        row.Cells.Add(px);
            //        //分辨率
            //        DataGridViewTextBoxCell deep = new DataGridViewTextBoxCell();
            //        deep.Value = img.HorizontalResolution + "X" + img.VerticalResolution;
            //        row.Cells.Add(deep);
            //        gvImg.Rows.Add(row);
            //    }                                                          //如果有多个文件,files[0]就是第一个文件的路径了
            //    //richTextBox1.Text = System.IO.File.ReadAllText(files[0]);//IO操作读入文本内容
            //}
        }
    }
}
