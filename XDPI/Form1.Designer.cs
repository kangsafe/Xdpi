﻿namespace XDPI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.filedlg = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderdlg = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gvImg = new System.Windows.Forms.DataGridView();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.fpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.px = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbpname = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbpath = new System.Windows.Forms.ToolStripTextBox();
            this.btnpath = new System.Windows.Forms.ToolStripButton();
            this.btnadd = new System.Windows.Forms.ToolStripButton();
            this.btntran = new System.Windows.Forms.ToolStripButton();
            this.btnZip = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.lhpi = new System.Windows.Forms.ToolStripMenuItem();
            this.mdpi = new System.Windows.Forms.ToolStripMenuItem();
            this.hdpi = new System.Windows.Forms.ToolStripMenuItem();
            this.xhdpi = new System.Windows.Forms.ToolStripMenuItem();
            this.xxhdpi = new System.Windows.Forms.ToolStripMenuItem();
            this.xxxhdpi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.word2PDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel2PDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visio2PDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pPT2PDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msProject2PDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDowloadimage = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImg)).BeginInit();
            this.tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "";
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1043, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "双击退出图片查看");
            this.pictureBox1.Visible = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(224, 217);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(601, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 12;
            // 
            // gvImg
            // 
            this.gvImg.AllowUserToOrderColumns = true;
            this.gvImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvImg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.img,
            this.fpath,
            this.fname,
            this.px,
            this.deep,
            this.result});
            this.gvImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvImg.Location = new System.Drawing.Point(0, 25);
            this.gvImg.Name = "gvImg";
            this.gvImg.RowTemplate.Height = 23;
            this.gvImg.Size = new System.Drawing.Size(1043, 490);
            this.gvImg.TabIndex = 14;
            this.gvImg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvImg_CellDoubleClick);
            // 
            // img
            // 
            this.img.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.img.FillWeight = 10F;
            this.img.HeaderText = "图片";
            this.img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.img.Name = "img";
            this.img.ToolTipText = "双击查看大图";
            // 
            // fpath
            // 
            this.fpath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fpath.FillWeight = 30F;
            this.fpath.HeaderText = "路径";
            this.fpath.Name = "fpath";
            // 
            // fname
            // 
            this.fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fname.FillWeight = 10F;
            this.fname.HeaderText = "文件名";
            this.fname.Name = "fname";
            // 
            // px
            // 
            this.px.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.px.FillWeight = 10F;
            this.px.HeaderText = "像素:宽X高";
            this.px.Name = "px";
            // 
            // deep
            // 
            this.deep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deep.FillWeight = 10F;
            this.deep.HeaderText = "分辨率:水平X垂直";
            this.deep.Name = "deep";
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.result.FillWeight = 30F;
            this.result.HeaderText = "结果";
            this.result.Name = "result";
            // 
            // tools
            // 
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tbpname,
            this.toolStripLabel1,
            this.tbpath,
            this.btnpath,
            this.btnadd,
            this.btntran,
            this.btnZip,
            this.toolStripComboBox1,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.btnDowloadimage});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(1043, 25);
            this.tools.TabIndex = 15;
            this.tools.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel2.Text = "资源前缀";
            // 
            // tbpname
            // 
            this.tbpname.Name = "tbpname";
            this.tbpname.Size = new System.Drawing.Size(60, 25);
            this.tbpname.Text = "mipmap";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "保存位置";
            // 
            // tbpath
            // 
            this.tbpath.Name = "tbpath";
            this.tbpath.Size = new System.Drawing.Size(100, 25);
            // 
            // btnpath
            // 
            this.btnpath.CheckOnClick = true;
            this.btnpath.Image = ((System.Drawing.Image)(resources.GetObject("btnpath.Image")));
            this.btnpath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnpath.Name = "btnpath";
            this.btnpath.Size = new System.Drawing.Size(52, 22);
            this.btnpath.Text = "选择";
            this.btnpath.ToolTipText = "选择";
            this.btnpath.Click += new System.EventHandler(this.btnpath_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(52, 22);
            this.btnadd.Text = "添加";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btntran
            // 
            this.btntran.Image = ((System.Drawing.Image)(resources.GetObject("btntran.Image")));
            this.btntran.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntran.Name = "btntran";
            this.btntran.Size = new System.Drawing.Size(52, 22);
            this.btntran.Text = "转换";
            this.btntran.Click += new System.EventHandler(this.btntran_Click);
            // 
            // btnZip
            // 
            this.btnZip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnZip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(57, 22);
            this.btnZip.Text = "TinyPng";
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "ldpi 120dpi 0.75",
            "mdpi 160dpi 1",
            "hdpi 240dpi 1.5",
            "xhdpi 320dpi 2",
            "xxhdpi 480dpi 3",
            "xxxhdpi 640dpi 4"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Visible = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lhpi,
            this.mdpi,
            this.hdpi,
            this.xhdpi,
            this.xxhdpi,
            this.xxxhdpi});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripDropDownButton1.Text = "选择尺寸";
            // 
            // lhpi
            // 
            this.lhpi.CheckOnClick = true;
            this.lhpi.Name = "lhpi";
            this.lhpi.Size = new System.Drawing.Size(120, 22);
            this.lhpi.Text = "lhpi";
            this.lhpi.CheckedChanged += new System.EventHandler(this.lhpi_CheckedChanged);
            // 
            // mdpi
            // 
            this.mdpi.Checked = true;
            this.mdpi.CheckOnClick = true;
            this.mdpi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mdpi.Name = "mdpi";
            this.mdpi.Size = new System.Drawing.Size(120, 22);
            this.mdpi.Text = "mdpi";
            this.mdpi.CheckedChanged += new System.EventHandler(this.mdpi_CheckedChanged);
            // 
            // hdpi
            // 
            this.hdpi.Checked = true;
            this.hdpi.CheckOnClick = true;
            this.hdpi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hdpi.Name = "hdpi";
            this.hdpi.Size = new System.Drawing.Size(120, 22);
            this.hdpi.Text = "hdpi";
            this.hdpi.CheckedChanged += new System.EventHandler(this.hdpi_CheckedChanged);
            // 
            // xhdpi
            // 
            this.xhdpi.Checked = true;
            this.xhdpi.CheckOnClick = true;
            this.xhdpi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xhdpi.Name = "xhdpi";
            this.xhdpi.Size = new System.Drawing.Size(120, 22);
            this.xhdpi.Text = "xhdpi";
            this.xhdpi.CheckedChanged += new System.EventHandler(this.xhdpi_CheckedChanged);
            // 
            // xxhdpi
            // 
            this.xxhdpi.Checked = true;
            this.xxhdpi.CheckOnClick = true;
            this.xxhdpi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xxhdpi.Name = "xxhdpi";
            this.xxhdpi.Size = new System.Drawing.Size(120, 22);
            this.xxhdpi.Text = "xxhdpi";
            this.xxhdpi.CheckedChanged += new System.EventHandler(this.xxhdpi_CheckedChanged);
            // 
            // xxxhdpi
            // 
            this.xxxhdpi.CheckOnClick = true;
            this.xxxhdpi.Name = "xxxhdpi";
            this.xxxhdpi.Size = new System.Drawing.Size(120, 22);
            this.xxxhdpi.Text = "xxxhdpi";
            this.xxxhdpi.CheckedChanged += new System.EventHandler(this.xxxhdpi_CheckedChanged);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.word2PDFToolStripMenuItem,
            this.excel2PDFToolStripMenuItem,
            this.visio2PDFToolStripMenuItem,
            this.pPT2PDFToolStripMenuItem,
            this.msProject2PDFToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(84, 22);
            this.toolStripDropDownButton2.Text = "Office2PDF";
            // 
            // word2PDFToolStripMenuItem
            // 
            this.word2PDFToolStripMenuItem.Name = "word2PDFToolStripMenuItem";
            this.word2PDFToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.word2PDFToolStripMenuItem.Text = "Word2PDF";
            this.word2PDFToolStripMenuItem.Click += new System.EventHandler(this.word2PDFToolStripMenuItem_Click);
            // 
            // excel2PDFToolStripMenuItem
            // 
            this.excel2PDFToolStripMenuItem.Name = "excel2PDFToolStripMenuItem";
            this.excel2PDFToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.excel2PDFToolStripMenuItem.Text = "Excel2PDF";
            this.excel2PDFToolStripMenuItem.Click += new System.EventHandler(this.excel2PDFToolStripMenuItem_Click);
            // 
            // visio2PDFToolStripMenuItem
            // 
            this.visio2PDFToolStripMenuItem.Name = "visio2PDFToolStripMenuItem";
            this.visio2PDFToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.visio2PDFToolStripMenuItem.Text = "Visio2PDF";
            this.visio2PDFToolStripMenuItem.Click += new System.EventHandler(this.visio2PDFToolStripMenuItem_Click);
            // 
            // pPT2PDFToolStripMenuItem
            // 
            this.pPT2PDFToolStripMenuItem.Name = "pPT2PDFToolStripMenuItem";
            this.pPT2PDFToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pPT2PDFToolStripMenuItem.Text = "PPT2PDF";
            this.pPT2PDFToolStripMenuItem.Click += new System.EventHandler(this.pPT2PDFToolStripMenuItem_Click);
            // 
            // msProject2PDFToolStripMenuItem
            // 
            this.msProject2PDFToolStripMenuItem.Name = "msProject2PDFToolStripMenuItem";
            this.msProject2PDFToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.msProject2PDFToolStripMenuItem.Text = "MsProject2PDF";
            this.msProject2PDFToolStripMenuItem.Click += new System.EventHandler(this.msProject2PDFToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "双击退出图片查看";
            // 
            // btnDowloadimage
            // 
            this.btnDowloadimage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDowloadimage.Image = ((System.Drawing.Image)(resources.GetObject("btnDowloadimage.Image")));
            this.btnDowloadimage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDowloadimage.Name = "btnDowloadimage";
            this.btnDowloadimage.Size = new System.Drawing.Size(60, 22);
            this.btnDowloadimage.Text = "下载图片";
            this.btnDowloadimage.Click += new System.EventHandler(this.btnDowloadimage_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 515);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gvImg);
            this.Controls.Add(this.tools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "菜渣渣--Android资源批量生成器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImg)).EndInit();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog filedlg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderdlg;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView gvImg;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbpath;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbpname;
        private System.Windows.Forms.ToolStripButton btnpath;
        private System.Windows.Forms.ToolStripButton btnadd;
        private System.Windows.Forms.ToolStripButton btntran;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn fpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn px;
        private System.Windows.Forms.DataGridViewTextBoxColumn deep;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem lhpi;
        private System.Windows.Forms.ToolStripMenuItem mdpi;
        private System.Windows.Forms.ToolStripMenuItem hdpi;
        private System.Windows.Forms.ToolStripMenuItem xhdpi;
        private System.Windows.Forms.ToolStripMenuItem xxhdpi;
        private System.Windows.Forms.ToolStripMenuItem xxxhdpi;
        private System.Windows.Forms.ToolStripButton btnZip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem word2PDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excel2PDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visio2PDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pPT2PDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msProject2PDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnDowloadimage;
    }
}

