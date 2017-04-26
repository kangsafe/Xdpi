using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Configuration;
using System.IO;
using System.Drawing.Imaging;

namespace XDPI
{

    public partial class FormImage : Form
    {
        private Form1 mainFrm;
        private string urlRoot = "http://asimg.zzxb.me";
        private string savepath;
        string mySqlCon = ConfigurationManager.ConnectionStrings["MySqlCon"].ConnectionString;
        private List<string> list = new List<string>();

        public FormImage(Form1 main)
        {
            InitializeComponent();
            this.mainFrm = main;
            savepath = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void FormImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoodBook();
            download();
        }

        private void download()
        {
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = list.Count;
            toolStripProgressBar1.Value = 0;
            WebClient client = new WebClient();

            foreach (string path in list)
            {
                toolStripProgressBar1.Value += 1;
                string temp = path;
                if (path.IndexOf("http://") > -1)
                {
                    temp = path.Replace(urlRoot, "");
                }
                Console.WriteLine(temp);
                string p = temp;
                temp = temp.Replace('/', '\\');
                string tempp = temp.Substring(0, temp.LastIndexOf('\\'));
                if (!Directory.Exists(savepath + tempp))
                {
                    Directory.CreateDirectory(savepath + tempp);
                }
                try
                {
                    client.DownloadFile(urlRoot + p, savepath + temp);
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
        //好书推荐
        private void GoodBook()
        {
            exec("Select bPicture From goodbooks");//goodbook;
            exec("select kPicture from goodketang");//goodketang;
            exec("select gtpicture from goodteachers");//goodteachers;
            exec("select jPicture from jiaoshuyuren");//教书育人;
            exec("select photo from ptuser");//教书育人;
            exec("select studentPhoto from student");//学生表;
            exec("select newsPicture from stunews");//新闻;            
            exec("select Content from tongzhispicture");//通知图片;
            exec("select tContent from tuispicture");//通知图片;
        }

        private void exec(string sql)
        {
            MySqlConnection myCon = new MySqlConnection(mySqlCon);

            try
            {
                myCon.Open();

                MySqlCommand selSql = new MySqlCommand(sql, myCon);

                //selSql.Parameters.Add("@uname", MySqlDbType.VarChar, 32).Value = this.txt_name.Text.Trim();

                MySqlDataReader mydr = selSql.ExecuteReader();

                while (mydr.Read())
                {
                    if (mydr.HasRows)
                    {
                        if (mydr.GetString(0).Length > 0)
                            list.Add(mydr.GetString(0).ToLower());
                    }
                }
                myCon.Close();
                mydr.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
