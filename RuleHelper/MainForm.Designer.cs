namespace RuleHelper
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            spcMain = new SplitContainer();
            pnlMain = new Panel();
            stsMain = new StatusStrip();
            drdbGotoPage = new ToolStripDropDownButton();
            txtpagination = new ToolStripTextBox();
            separator = new ToolStripSeparator();
            txtGotoPage = new ToolStripTextBox();
            cmbGotoPage = new ToolStripComboBox();
            stsLog = new ToolStripStatusLabel();
            lstvThumbnail = new ListView();
            textBox1 = new TextBox();
            btnSearch = new Button();
            txtUrl = new TextBox();
            mensMain = new MenuStrip();
            파일ToolStripMenuItem = new ToolStripMenuItem();
            종료XToolStripMenuItem = new ToolStripMenuItem();
            보기ToolStripMenuItem = new ToolStripMenuItem();
            이미지화면열기VToolStripMenuItem = new ToolStripMenuItem();
            다운로드ToolStripMenuItem = new ToolStripMenuItem();
            선택한파일다운로드ToolStripMenuItem = new ToolStripMenuItem();
            전체파일다운로드ToolStripMenuItem = new ToolStripMenuItem();
            도움말ToolStripMenuItem = new ToolStripMenuItem();
            로그LToolStripMenuItem = new ToolStripMenuItem();
            spcImage = new SplitContainer();
            picbDetailImage = new PictureBox();
            ImglThumbnail = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)spcMain).BeginInit();
            spcMain.Panel1.SuspendLayout();
            spcMain.Panel2.SuspendLayout();
            spcMain.SuspendLayout();
            pnlMain.SuspendLayout();
            stsMain.SuspendLayout();
            mensMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spcImage).BeginInit();
            spcImage.Panel2.SuspendLayout();
            spcImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbDetailImage).BeginInit();
            SuspendLayout();
            // 
            // spcMain
            // 
            spcMain.Dock = DockStyle.Fill;
            spcMain.FixedPanel = FixedPanel.Panel1;
            spcMain.IsSplitterFixed = true;
            spcMain.Location = new Point(0, 0);
            spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            spcMain.Panel1.Controls.Add(pnlMain);
            // 
            // spcMain.Panel2
            // 
            spcMain.Panel2.Controls.Add(spcImage);
            spcMain.Size = new Size(1048, 818);
            spcMain.SplitterDistance = 418;
            spcMain.SplitterWidth = 1;
            spcMain.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(stsMain);
            pnlMain.Controls.Add(lstvThumbnail);
            pnlMain.Controls.Add(textBox1);
            pnlMain.Controls.Add(btnSearch);
            pnlMain.Controls.Add(txtUrl);
            pnlMain.Controls.Add(mensMain);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(418, 818);
            pnlMain.TabIndex = 0;
            // 
            // stsMain
            // 
            stsMain.Items.AddRange(new ToolStripItem[] { drdbGotoPage, stsLog });
            stsMain.Location = new Point(0, 796);
            stsMain.Name = "stsMain";
            stsMain.Size = new Size(418, 22);
            stsMain.TabIndex = 5;
            stsMain.Text = "statusStrip1";
            // 
            // drdbGotoPage
            // 
            drdbGotoPage.DisplayStyle = ToolStripItemDisplayStyle.Text;
            drdbGotoPage.DropDownItems.AddRange(new ToolStripItem[] { txtpagination, separator, txtGotoPage, cmbGotoPage });
            drdbGotoPage.ImageScaling = ToolStripItemImageScaling.None;
            drdbGotoPage.ImageTransparentColor = Color.Magenta;
            drdbGotoPage.Name = "drdbGotoPage";
            drdbGotoPage.Size = new Size(76, 20);
            drdbGotoPage.Text = "Goto Page";
            // 
            // txtpagination
            // 
            txtpagination.BorderStyle = BorderStyle.None;
            txtpagination.Name = "txtpagination";
            txtpagination.ReadOnly = true;
            txtpagination.Size = new Size(100, 16);
            // 
            // separator
            // 
            separator.Name = "separator";
            separator.Size = new Size(178, 6);
            // 
            // txtGotoPage
            // 
            txtGotoPage.Name = "txtGotoPage";
            txtGotoPage.Size = new Size(100, 23);
            txtGotoPage.Visible = false;
            // 
            // cmbGotoPage
            // 
            cmbGotoPage.Name = "cmbGotoPage";
            cmbGotoPage.Size = new Size(121, 23);
            cmbGotoPage.SelectedIndexChanged += SelectPageIndex;
            // 
            // stsLog
            // 
            stsLog.BorderSides = ToolStripStatusLabelBorderSides.Left;
            stsLog.BorderStyle = Border3DStyle.Etched;
            stsLog.Name = "stsLog";
            stsLog.Size = new Size(4, 17);
            // 
            // lstvThumbnail
            // 
            lstvThumbnail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstvThumbnail.Location = new Point(0, 63);
            lstvThumbnail.Name = "lstvThumbnail";
            lstvThumbnail.Size = new Size(418, 730);
            lstvThumbnail.TabIndex = 4;
            lstvThumbnail.UseCompatibleStateImageBehavior = false;
            lstvThumbnail.View = View.List;
            lstvThumbnail.SelectedIndexChanged += DisplayDetailImage;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.Enabled = false;
            textBox1.Location = new Point(3, 56);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(411, 1);
            textBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(340, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += SeachUrl;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(3, 27);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(331, 23);
            txtUrl.TabIndex = 1;
            txtUrl.Text = "URL을 입력하세요";
            // 
            // mensMain
            // 
            mensMain.Items.AddRange(new ToolStripItem[] { 파일ToolStripMenuItem, 보기ToolStripMenuItem, 다운로드ToolStripMenuItem, 도움말ToolStripMenuItem });
            mensMain.Location = new Point(0, 0);
            mensMain.Name = "mensMain";
            mensMain.Size = new Size(418, 24);
            mensMain.TabIndex = 0;
            mensMain.Visible = false;
            // 
            // 파일ToolStripMenuItem
            // 
            파일ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 종료XToolStripMenuItem });
            파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            파일ToolStripMenuItem.Size = new Size(57, 20);
            파일ToolStripMenuItem.Text = "파일(&F)";
            // 
            // 종료XToolStripMenuItem
            // 
            종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            종료XToolStripMenuItem.Size = new Size(113, 22);
            종료XToolStripMenuItem.Text = "종료(&X)";
            // 
            // 보기ToolStripMenuItem
            // 
            보기ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 이미지화면열기VToolStripMenuItem });
            보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            보기ToolStripMenuItem.Size = new Size(59, 20);
            보기ToolStripMenuItem.Text = "보기(&V)";
            // 
            // 이미지화면열기VToolStripMenuItem
            // 
            이미지화면열기VToolStripMenuItem.Name = "이미지화면열기VToolStripMenuItem";
            이미지화면열기VToolStripMenuItem.Size = new Size(182, 22);
            이미지화면열기VToolStripMenuItem.Text = "이미지 화면 열기(&V)";
            // 
            // 다운로드ToolStripMenuItem
            // 
            다운로드ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 선택한파일다운로드ToolStripMenuItem, 전체파일다운로드ToolStripMenuItem });
            다운로드ToolStripMenuItem.Name = "다운로드ToolStripMenuItem";
            다운로드ToolStripMenuItem.Size = new Size(84, 20);
            다운로드ToolStripMenuItem.Text = "다운로드(&D)";
            // 
            // 선택한파일다운로드ToolStripMenuItem
            // 
            선택한파일다운로드ToolStripMenuItem.Name = "선택한파일다운로드ToolStripMenuItem";
            선택한파일다운로드ToolStripMenuItem.Size = new Size(206, 22);
            선택한파일다운로드ToolStripMenuItem.Text = "선택한 파일 다운로드(&A)";
            // 
            // 전체파일다운로드ToolStripMenuItem
            // 
            전체파일다운로드ToolStripMenuItem.Name = "전체파일다운로드ToolStripMenuItem";
            전체파일다운로드ToolStripMenuItem.Size = new Size(206, 22);
            전체파일다운로드ToolStripMenuItem.Text = "전체 파일 다운로드(&D)";
            // 
            // 도움말ToolStripMenuItem
            // 
            도움말ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 로그LToolStripMenuItem });
            도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            도움말ToolStripMenuItem.Size = new Size(72, 20);
            도움말ToolStripMenuItem.Text = "도움말(&H)";
            // 
            // 로그LToolStripMenuItem
            // 
            로그LToolStripMenuItem.Name = "로그LToolStripMenuItem";
            로그LToolStripMenuItem.Size = new Size(112, 22);
            로그LToolStripMenuItem.Text = "로그(&L)";
            // 
            // spcImage
            // 
            spcImage.Dock = DockStyle.Fill;
            spcImage.FixedPanel = FixedPanel.Panel1;
            spcImage.IsSplitterFixed = true;
            spcImage.Location = new Point(0, 0);
            spcImage.Name = "spcImage";
            // 
            // spcImage.Panel1
            // 
            spcImage.Panel1.BackColor = Color.Black;
            spcImage.Panel1MinSize = 1;
            // 
            // spcImage.Panel2
            // 
            spcImage.Panel2.Controls.Add(picbDetailImage);
            spcImage.Size = new Size(629, 818);
            spcImage.SplitterDistance = 25;
            spcImage.SplitterWidth = 1;
            spcImage.TabIndex = 0;
            // 
            // picbDetailImage
            // 
            picbDetailImage.Dock = DockStyle.Fill;
            picbDetailImage.Location = new Point(0, 0);
            picbDetailImage.Name = "picbDetailImage";
            picbDetailImage.Size = new Size(603, 818);
            picbDetailImage.SizeMode = PictureBoxSizeMode.Zoom;
            picbDetailImage.TabIndex = 1;
            picbDetailImage.TabStop = false;
            // 
            // ImglThumbnail
            // 
            ImglThumbnail.ColorDepth = ColorDepth.Depth32Bit;
            ImglThumbnail.ImageStream = (ImageListStreamer)resources.GetObject("ImglThumbnail.ImageStream");
            ImglThumbnail.TransparentColor = Color.Transparent;
            ImglThumbnail.Images.SetKeyName(0, "0");
            ImglThumbnail.Images.SetKeyName(1, "thumbnail_1cb1e4dc5c107f0bb044516558ea0514.jpg");
            ImglThumbnail.Images.SetKeyName(2, "thumbnail_1dbe2cb43284d7ee1277361811e01b50.jpg");
            ImglThumbnail.Images.SetKeyName(3, "thumbnail_2b39a37b49e90c898d2344e37fc3cb3a.jpg");
            ImglThumbnail.Images.SetKeyName(4, "thumbnail_03dded1d6668e822ae318b2bb748ea0a.jpg");
            ImglThumbnail.Images.SetKeyName(5, "thumbnail_6fe9789ca56512b3990ed83930851143.jpg");
            ImglThumbnail.Images.SetKeyName(6, "thumbnail_7b680f77c2b13facb4ae7300f7986721.jpg");
            ImglThumbnail.Images.SetKeyName(7, "thumbnail_8dcf49c3b55d774276507ef476aabf73.jpg");
            ImglThumbnail.Images.SetKeyName(8, "thumbnail_9fce44091f52dd52704202729135a922.jpg");
            ImglThumbnail.Images.SetKeyName(9, "thumbnail_11e2ebb0231af9e9b89d97ad74d289e4.jpg");
            ImglThumbnail.Images.SetKeyName(10, "thumbnail_25f5a794e90c65f11958ddecfdccf02d.jpg");
            ImglThumbnail.Images.SetKeyName(11, "thumbnail_26fa7720956f0ae8a58ab37b94b8ab9b.jpg");
            ImglThumbnail.Images.SetKeyName(12, "thumbnail_49fd3e7300782a76b1b7b6893779c32a.jpg");
            ImglThumbnail.Images.SetKeyName(13, "thumbnail_51eb58fa208dce929588169a4bd7e89a.jpg");
            ImglThumbnail.Images.SetKeyName(14, "thumbnail_54a58ac4615dc03b247ccc9cf544f0e1.jpg");
            ImglThumbnail.Images.SetKeyName(15, "thumbnail_72cc4c117b06cad28f95fb93dec80052.jpg");
            ImglThumbnail.Images.SetKeyName(16, "thumbnail_97b6daf7ebf600f4a3a1c2c02fb06368.jpg");
            ImglThumbnail.Images.SetKeyName(17, "thumbnail_511df1cb869fdb9f0c61188279bab3ea.jpg");
            ImglThumbnail.Images.SetKeyName(18, "thumbnail_1226f8cf37ce18ac30d4b82af4ef9847.jpg");
            ImglThumbnail.Images.SetKeyName(19, "thumbnail_4687c6e9bc2c0bdb6d4df05f532221de.jpg");
            ImglThumbnail.Images.SetKeyName(20, "thumbnail_84534afb7afce2654f050430780a28b9.jpg");
            ImglThumbnail.Images.SetKeyName(21, "thumbnail_93596c019bd9c43689cc52bf147a5139.jpg");
            ImglThumbnail.Images.SetKeyName(22, "thumbnail_a9f99258e54139f8b4bebc2db65fd46d.jpg");
            ImglThumbnail.Images.SetKeyName(23, "thumbnail_a774fc5dcfd6a1c7e09f20654475775d.jpg");
            ImglThumbnail.Images.SetKeyName(24, "thumbnail_b73c3573f10abc90f9ed6e97bbb80e34.jpg");
            ImglThumbnail.Images.SetKeyName(25, "thumbnail_bde7c1f1cf0ddee3fb65957b22798507.jpg");
            ImglThumbnail.Images.SetKeyName(26, "thumbnail_c3f0cfbef255688504118fef257c5925.jpg");
            ImglThumbnail.Images.SetKeyName(27, "thumbnail_cb6ed25cc9c5bb658f2b440dbea83d67.jpg");
            ImglThumbnail.Images.SetKeyName(28, "thumbnail_d7b646501b1184b99f0f66e7f06dbdf4.jpg");
            ImglThumbnail.Images.SetKeyName(29, "thumbnail_d493d1c0b3883d689e7c43d211b36508.jpg");
            ImglThumbnail.Images.SetKeyName(30, "thumbnail_d735586f8d608757cbb2dadc44455fd4.jpg");
            ImglThumbnail.Images.SetKeyName(31, "thumbnail_db8ce95869e74938e1af4fe23389a28c.jpg");
            ImglThumbnail.Images.SetKeyName(32, "thumbnail_e3e684a07b3f999658290b4248ad96aa.jpg");
            ImglThumbnail.Images.SetKeyName(33, "thumbnail_e55f553e2d2001a12e6797de770038fd.jpg");
            ImglThumbnail.Images.SetKeyName(34, "thumbnail_eb07520a7e78ca371f001cd1050a30e5.jpg");
            ImglThumbnail.Images.SetKeyName(35, "thumbnail_f2abf4f2d6e03c68a9cf787488cb137c.jpg");
            ImglThumbnail.Images.SetKeyName(36, "thumbnail_f7ee1c2d46d2117cfcd08c9f21ff4593.jpg");
            ImglThumbnail.Images.SetKeyName(37, "thumbnail_f9aaed1d53417f7be74a59687a9d6ce9.jpg");
            ImglThumbnail.Images.SetKeyName(38, "thumbnail_f57bc023f62ea34688aa71402d08bcb0.jpg");
            ImglThumbnail.Images.SetKeyName(39, "thumbnail_f159e59efacdd4d5ccdcfb6f0ae66be9.jpg");
            ImglThumbnail.Images.SetKeyName(40, "thumbnail_f49307cc816dda437f94c270132f1074.jpg");
            ImglThumbnail.Images.SetKeyName(41, "thumbnail_f117739ca178bbf01975a6a525bbcdf2.jpg");
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1048, 818);
            Controls.Add(spcMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "Ruxx Helper";
            spcMain.Panel1.ResumeLayout(false);
            spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcMain).EndInit();
            spcMain.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            stsMain.ResumeLayout(false);
            stsMain.PerformLayout();
            mensMain.ResumeLayout(false);
            mensMain.PerformLayout();
            spcImage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcImage).EndInit();
            spcImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picbDetailImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer spcMain;
        private Panel pnlMain;
        private MenuStrip mensMain;
        private SplitContainer spcImage;
        private ToolStripMenuItem 파일ToolStripMenuItem;
        private ToolStripMenuItem 보기ToolStripMenuItem;
        private Button btnSearch;
        private TextBox txtUrl;
        private TextBox textBox1;
        private ImageList ImglThumbnail;
        private ListView lstvThumbnail;
        private ToolStripMenuItem 다운로드ToolStripMenuItem;
        private ToolStripMenuItem 선택한파일다운로드ToolStripMenuItem;
        private ToolStripMenuItem 전체파일다운로드ToolStripMenuItem;
        private ToolStripMenuItem 종료XToolStripMenuItem;
        private ToolStripMenuItem 이미지화면열기VToolStripMenuItem;
        private ToolStripMenuItem 도움말ToolStripMenuItem;
        private ToolStripMenuItem 로그LToolStripMenuItem;
        private PictureBox picbDetailImage;
        private StatusStrip stsMain;
        private ToolStripDropDownButton drdbGotoPage;
        private ToolStripTextBox txtGotoPage;
        private ToolStripComboBox cmbGotoPage;
        private ToolStripStatusLabel stsLog;
        private ToolStripTextBox txtpagination;
        private ToolStripSeparator separator;
    }
}
