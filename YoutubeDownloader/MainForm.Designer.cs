namespace YoutubeDownloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtVideoUrl = new TextBox();
            btnGetVideoData = new Button();
            selectVideoQuality = new ComboBox();
            lblTitle = new Label();
            btnDownloadVideo = new Button();
            imgVideoThumbnail = new PictureBox();
            btnDownloadThumbnail = new Button();
            selectThumbnailQuality = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgVideoThumbnail).BeginInit();
            SuspendLayout();
            // 
            // txtVideoUrl
            // 
            txtVideoUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVideoUrl.BackColor = Color.FromArgb(16, 168, 171);
            txtVideoUrl.BorderStyle = BorderStyle.None;
            txtVideoUrl.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVideoUrl.ForeColor = Color.White;
            txtVideoUrl.Location = new Point(87, 73);
            txtVideoUrl.MinimumSize = new Size(314, 24);
            txtVideoUrl.Name = "txtVideoUrl";
            txtVideoUrl.PlaceholderText = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            txtVideoUrl.Size = new Size(314, 24);
            txtVideoUrl.TabIndex = 1;
            txtVideoUrl.TabStop = false;
            // 
            // btnGetVideoData
            // 
            btnGetVideoData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetVideoData.BackColor = Color.FromArgb(16, 168, 171);
            btnGetVideoData.Cursor = Cursors.Hand;
            btnGetVideoData.FlatStyle = FlatStyle.Flat;
            btnGetVideoData.Font = new Font("Tahoma", 9.75F);
            btnGetVideoData.ForeColor = Color.White;
            btnGetVideoData.Location = new Point(407, 70);
            btnGetVideoData.Name = "btnGetVideoData";
            btnGetVideoData.Size = new Size(85, 30);
            btnGetVideoData.TabIndex = 2;
            btnGetVideoData.TabStop = false;
            btnGetVideoData.Text = "Get Data";
            btnGetVideoData.UseVisualStyleBackColor = false;
            btnGetVideoData.Click += btnGetVideoData_Click;
            // 
            // selectVideoQuality
            // 
            selectVideoQuality.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectVideoQuality.BackColor = Color.FromArgb(16, 168, 171);
            selectVideoQuality.DropDownStyle = ComboBoxStyle.DropDownList;
            selectVideoQuality.Enabled = false;
            selectVideoQuality.FlatStyle = FlatStyle.Flat;
            selectVideoQuality.Font = new Font("Tahoma", 9.75F);
            selectVideoQuality.ForeColor = Color.White;
            selectVideoQuality.FormattingEnabled = true;
            selectVideoQuality.Location = new Point(87, 338);
            selectVideoQuality.Name = "selectVideoQuality";
            selectVideoQuality.Size = new Size(314, 24);
            selectVideoQuality.TabIndex = 3;
            selectVideoQuality.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 9.75F);
            lblTitle.Location = new Point(13, 107);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(116, 16);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Waiting for video...";
            lblTitle.Visible = false;
            lblTitle.TextChanged += lblTitle_TextChanged;
            // 
            // btnDownloadVideo
            // 
            btnDownloadVideo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDownloadVideo.BackColor = Color.FromArgb(16, 168, 171);
            btnDownloadVideo.Cursor = Cursors.Hand;
            btnDownloadVideo.Enabled = false;
            btnDownloadVideo.FlatStyle = FlatStyle.Flat;
            btnDownloadVideo.Font = new Font("Tahoma", 9.75F);
            btnDownloadVideo.ForeColor = Color.White;
            btnDownloadVideo.Location = new Point(407, 335);
            btnDownloadVideo.Name = "btnDownloadVideo";
            btnDownloadVideo.Size = new Size(85, 30);
            btnDownloadVideo.TabIndex = 5;
            btnDownloadVideo.TabStop = false;
            btnDownloadVideo.Text = "Download";
            btnDownloadVideo.UseVisualStyleBackColor = false;
            btnDownloadVideo.Click += btnDownloadVideo_Click;
            // 
            // imgVideoThumbnail
            // 
            imgVideoThumbnail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imgVideoThumbnail.Image = Properties.Resources.FallBackImage;
            imgVideoThumbnail.Location = new Point(116, 131);
            imgVideoThumbnail.Name = "imgVideoThumbnail";
            imgVideoThumbnail.Size = new Size(275, 145);
            imgVideoThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
            imgVideoThumbnail.TabIndex = 6;
            imgVideoThumbnail.TabStop = false;
            // 
            // btnDownloadThumbnail
            // 
            btnDownloadThumbnail.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDownloadThumbnail.BackColor = Color.FromArgb(16, 168, 171);
            btnDownloadThumbnail.Cursor = Cursors.Hand;
            btnDownloadThumbnail.Enabled = false;
            btnDownloadThumbnail.FlatStyle = FlatStyle.Flat;
            btnDownloadThumbnail.Font = new Font("Tahoma", 9.75F);
            btnDownloadThumbnail.ForeColor = Color.White;
            btnDownloadThumbnail.Location = new Point(407, 292);
            btnDownloadThumbnail.Name = "btnDownloadThumbnail";
            btnDownloadThumbnail.Size = new Size(85, 30);
            btnDownloadThumbnail.TabIndex = 8;
            btnDownloadThumbnail.TabStop = false;
            btnDownloadThumbnail.Text = "Download";
            btnDownloadThumbnail.UseVisualStyleBackColor = false;
            btnDownloadThumbnail.Click += btnDownloadThumbnail_Click;
            // 
            // selectThumbnailQuality
            // 
            selectThumbnailQuality.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectThumbnailQuality.BackColor = Color.FromArgb(16, 168, 171);
            selectThumbnailQuality.DropDownStyle = ComboBoxStyle.DropDownList;
            selectThumbnailQuality.Enabled = false;
            selectThumbnailQuality.FlatStyle = FlatStyle.Flat;
            selectThumbnailQuality.Font = new Font("Tahoma", 9.75F);
            selectThumbnailQuality.ForeColor = Color.White;
            selectThumbnailQuality.FormattingEnabled = true;
            selectThumbnailQuality.Location = new Point(87, 296);
            selectThumbnailQuality.Name = "selectThumbnailQuality";
            selectThumbnailQuality.Size = new Size(314, 24);
            selectThumbnailQuality.TabIndex = 7;
            selectThumbnailQuality.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F);
            label2.Location = new Point(13, 299);
            label2.Name = "label2";
            label2.Size = new Size(72, 16);
            label2.TabIndex = 9;
            label2.Text = "Thumbnail:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F);
            label3.Location = new Point(13, 342);
            label3.Name = "label3";
            label3.Size = new Size(44, 16);
            label3.TabIndex = 10;
            label3.Text = "Video:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F);
            label1.Location = new Point(13, 74);
            label1.Name = "label1";
            label1.Size = new Size(64, 16);
            label1.TabIndex = 11;
            label1.Text = "Video Url:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(80, 19);
            label4.Name = "label4";
            label4.Size = new Size(342, 41);
            label4.TabIndex = 12;
            label4.Text = "Youtube Downloader";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 37, 61);
            ClientSize = new Size(504, 381);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDownloadThumbnail);
            Controls.Add(selectThumbnailQuality);
            Controls.Add(imgVideoThumbnail);
            Controls.Add(btnDownloadVideo);
            Controls.Add(lblTitle);
            Controls.Add(selectVideoQuality);
            Controls.Add(btnGetVideoData);
            Controls.Add(txtVideoUrl);
            ForeColor = SystemColors.ControlLightLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(520, 420);
            Name = "MainForm";
            Text = "Youtube Downloader";
            ((System.ComponentModel.ISupportInitialize)imgVideoThumbnail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVideoUrl;
        private Button btnGetVideoData;
        private ComboBox selectVideoQuality;
        private Label lblTitle;
        private Button btnDownloadVideo;
        private PictureBox imgVideoThumbnail;
        private Button btnDownloadThumbnail;
        private ComboBox selectThumbnailQuality;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
    }
}
