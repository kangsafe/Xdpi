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
        private string filefullname = "";
        private string filename = "";
        private string prepath = "";
        private string ext = "";
        public Form1()
        {
            InitializeComponent();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                filefullname = openFileDialog1.FileName;
                ext = Path.GetExtension(filefullname);
                filename = Path.GetFileNameWithoutExtension(filefullname);
                textBox1.Text = filefullname;
                tbfname.Text = filename;
                Image img = Image.FromFile(filefullname);
                pictureBox1.Image = img;
                label2.Text = "宽度:" + img.Width + "高度:" + img.Height;
                label3.Text = "水平分辨率：" + img.HorizontalResolution + "垂直分辨率" + img.VerticalResolution;
            }
        }
        private string[] paths = { "-xxxhdpi", "-xxhdpi", "-xhdpi", "-hdpi", "-mdpi", "-ldpi" };
        private double[] rates = { 4, 3, 2, 1.5, 1, 0.75 };
        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Value = 0;
                progressBar1.Show();
                //保存路径
                savepath = folderBrowserDialog1.SelectedPath;
                filename = tbfname.Text + ext;
                prepath = tbpname.Text;

                for (int i = 0; i < paths.Length; i++)
                {
                    Thread.Sleep(1000);
                    progressBar1.Value = i / paths.Length * 100;
                    Bitmap oldbmp = new Bitmap(filefullname);
                    string temp = savepath + "\\" + prepath + paths[i];
                    if (!Directory.Exists(temp))
                    {
                        Directory.CreateDirectory(temp);
                    }
                    string fp = temp + "\\" + filename;
                    if (!File.Exists(fp))
                    {
                        Bitmap bmp = GetThumbnail(oldbmp, rates[i] / rates[0]);
                        bmp.Save(fp);
                        bmp.Dispose();
                    }
                }
            }
            progressBar1.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
    }
}
