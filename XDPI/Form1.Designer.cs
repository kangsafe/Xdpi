namespace XDPI
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
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbpath = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbpname = new System.Windows.Forms.ToolStripTextBox();
            this.btnpath = new System.Windows.Forms.ToolStripButton();
            this.btnadd = new System.Windows.Forms.ToolStripButton();
            this.btntran = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.fpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.px = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.pictureBox1.Size = new System.Drawing.Size(799, 490);
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
            this.progressBar1.Size = new System.Drawing.Size(357, 23);
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
            this.gvImg.Size = new System.Drawing.Size(799, 490);
            this.gvImg.TabIndex = 14;
            this.gvImg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvImg_CellDoubleClick);
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
            this.toolStripComboBox1});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(799, 25);
            this.tools.TabIndex = 15;
            this.tools.Text = "toolStrip1";
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
            this.tbpath.Size = new System.Drawing.Size(200, 25);
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
            this.tbpname.Size = new System.Drawing.Size(100, 25);
            this.tbpname.Text = "mipmap";
            // 
            // btnpath
            // 
            this.btnpath.CheckOnClick = true;
            this.btnpath.Image = ((System.Drawing.Image)(resources.GetObject("btnpath.Image")));
            this.btnpath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnpath.Name = "btnpath";
            this.btnpath.Size = new System.Drawing.Size(76, 22);
            this.btnpath.Text = "选择目录";
            this.btnpath.Click += new System.EventHandler(this.btnpath_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(76, 22);
            this.btnadd.Text = "添加图片";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btntran
            // 
            this.btntran.Image = ((System.Drawing.Image)(resources.GetObject("btntran.Image")));
            this.btntran.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntran.Name = "btntran";
            this.btntran.Size = new System.Drawing.Size(76, 22);
            this.btntran.Text = "开始转换";
            this.btntran.Click += new System.EventHandler(this.btntran_Click);
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
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "双击退出图片查看";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 515);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gvImg);
            this.Controls.Add(this.tools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "菜渣渣--Android资源批量生成器";
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
    }
}

