using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace XDPI
{
    public partial class FormTinyPng : Form
    {
        private Form1 frm;
        private string savepath = "";

        public FormTinyPng(Form1 frm)
        {
            this.frm = frm;
            InitializeComponent();
            savepath = AppDomain.CurrentDomain.BaseDirectory + "temp";
            tbpath.Text = savepath;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //选择目录
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                savepath = folderBrowserDialog1.SelectedPath;
                tbpath.Text = savepath;
                getAllFiles(savepath);
                list = list.Where(t => t.ToLower().EndsWith(".png") || t.ToLower().EndsWith(".jpg")).ToList();
                Console.WriteLine(list.Count);
                lblcount.Text = "共计：" + list.Count.ToString();
                foreach (string f in list)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    //路径
                    DataGridViewTextBoxCell path = new DataGridViewTextBoxCell();
                    path.Value = f;
                    row.Cells.Add(path);
                    //路径
                    DataGridViewTextBoxCell status = new DataGridViewTextBoxCell();
                    status.Value = "";
                    row.Cells.Add(status);
                    dataGridView1.Rows.Add(row);
                    dataGridView1.Refresh();
                }
            }
        }

        public string[] GetDirs(string path)
        {
            try
            {
                return Directory.GetDirectories(path);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string[] getFiles(string path)
        {
            try
            {
                return Directory.GetFiles(path);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        private List<string> list = new List<string>();
        public void getAllFiles(string path)
        {
            string[] files = getFiles(path);
            if (files != null && files.Length > 0)
            {
                list.AddRange(files);
            }
            string[] dirs = GetDirs(path);
            if (dirs != null && dirs.Length > 0)
            {
                foreach (string dir in dirs)
                {
                    getAllFiles(dir);
                }
            }
        }

        public void tinypng(string path)
        {
            string key = "uTx9Gl3VZY3xS6AJO8AnREux08o_4QYT";

            string url = "https://api.tinify.com/shrink";

            WebClient client = new WebClient();
            string auth = Convert.ToBase64String(Encoding.UTF8.GetBytes("api:" + key));
            client.Headers.Add(HttpRequestHeader.Authorization, "Basic " + auth);
            try
            {
                dataGridView1.Rows[progressBar1.Value].Cells[1].Value = "转换中...";
                dataGridView1.Rows[progressBar1.Value].Cells[1].Style.ForeColor = Color.Yellow;
                dataGridView1.Refresh();
                client.UploadData(url, File.ReadAllBytes(path));
                /* Compression was successful, retrieve output from Location header. */
                client.DownloadFile(client.ResponseHeaders["Location"], path);
                dataGridView1.Rows[progressBar1.Value].Cells[1].Value = "转换成功";
                dataGridView1.Rows[progressBar1.Value].Cells[1].Style.ForeColor = Color.Green;
                dataGridView1.Refresh();
            }
            catch (WebException)
            {
                dataGridView1.Rows[progressBar1.Value].Cells[1].Value = "转换失败";
                dataGridView1.Rows[progressBar1.Value].Cells[1].Style.ForeColor = Color.Red;
                dataGridView1.Refresh();
                /* Something went wrong! You can parse the JSON body for details. */
                Console.WriteLine("Compression failed.");
            }
        }

        private void tbstart_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = list.Count;
                progressBar1.Value = 0;
                foreach (string f in list)
                {
                    dataGridView1.Rows[progressBar1.Value].Cells[1].Value = "开始";
                    dataGridView1.Refresh();
                    tinypng(f);
                    progressBar1.Value += 1;
                }
            }
            else
            {
                MessageBox.Show("请选择转换文件目录");
            }
        }

        private void FormTinyPng_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Show();
        }
    }
}
