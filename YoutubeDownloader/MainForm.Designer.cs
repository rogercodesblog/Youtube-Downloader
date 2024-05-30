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
            pictureIcon = new PictureBox();
            panelWaitingForVideoData = new Panel();
            lblVideoStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)imgVideoThumbnail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureIcon).BeginInit();
            panelWaitingForVideoData.SuspendLayout();
            SuspendLayout();
            // 
            // txtVideoUrl
            // 
            txtVideoUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVideoUrl.BackColor = Color.FromArgb(74, 188, 150);
            txtVideoUrl.BorderStyle = BorderStyle.None;
            txtVideoUrl.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVideoUrl.ForeColor = Color.White;
            txtVideoUrl.Location = new Point(77, 73);
            txtVideoUrl.MinimumSize = new Size(314, 24);
            txtVideoUrl.Multiline = true;
            txtVideoUrl.Name = "txtVideoUrl";
            txtVideoUrl.PlaceholderText = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            txtVideoUrl.Size = new Size(350, 24);
            txtVideoUrl.TabIndex = 1;
            txtVideoUrl.TabStop = false;
            // 
            // btnGetVideoData
            // 
            btnGetVideoData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetVideoData.BackColor = Color.FromArgb(74, 188, 150);
            btnGetVideoData.Cursor = Cursors.Hand;
            btnGetVideoData.FlatStyle = FlatStyle.Flat;
            btnGetVideoData.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetVideoData.ForeColor = Color.White;
            btnGetVideoData.Location = new Point(433, 70);
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
            selectVideoQuality.BackColor = Color.FromArgb(74, 188, 150);
            selectVideoQuality.DropDownStyle = ComboBoxStyle.DropDownList;
            selectVideoQuality.Enabled = false;
            selectVideoQuality.FlatStyle = FlatStyle.Flat;
            selectVideoQuality.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectVideoQuality.ForeColor = Color.White;
            selectVideoQuality.FormattingEnabled = true;
            selectVideoQuality.Location = new Point(77, 383);
            selectVideoQuality.Name = "selectVideoQuality";
            selectVideoQuality.Size = new Size(350, 21);
            selectVideoQuality.TabIndex = 3;
            selectVideoQuality.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblTitle.Location = new Point(11, 109);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(116, 13);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Waiting for video...";
            lblTitle.Visible = false;
            lblTitle.TextChanged += lblTitle_TextChanged;
            // 
            // btnDownloadVideo
            // 
            btnDownloadVideo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDownloadVideo.BackColor = Color.FromArgb(74, 188, 150);
            btnDownloadVideo.Cursor = Cursors.Hand;
            btnDownloadVideo.Enabled = false;
            btnDownloadVideo.FlatStyle = FlatStyle.Flat;
            btnDownloadVideo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownloadVideo.ForeColor = Color.White;
            btnDownloadVideo.Location = new Point(433, 380);
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
            imgVideoThumbnail.Location = new Point(99, 134);
            imgVideoThumbnail.Name = "imgVideoThumbnail";
            imgVideoThumbnail.Size = new Size(311, 182);
            imgVideoThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
            imgVideoThumbnail.TabIndex = 6;
            imgVideoThumbnail.TabStop = false;
            // 
            // btnDownloadThumbnail
            // 
            btnDownloadThumbnail.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDownloadThumbnail.BackColor = Color.FromArgb(74, 188, 150);
            btnDownloadThumbnail.Cursor = Cursors.Hand;
            btnDownloadThumbnail.Enabled = false;
            btnDownloadThumbnail.FlatStyle = FlatStyle.Flat;
            btnDownloadThumbnail.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownloadThumbnail.ForeColor = Color.White;
            btnDownloadThumbnail.Location = new Point(433, 337);
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
            selectThumbnailQuality.BackColor = Color.FromArgb(74, 188, 150);
            selectThumbnailQuality.DropDownStyle = ComboBoxStyle.DropDownList;
            selectThumbnailQuality.Enabled = false;
            selectThumbnailQuality.FlatStyle = FlatStyle.Flat;
            selectThumbnailQuality.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectThumbnailQuality.ForeColor = Color.White;
            selectThumbnailQuality.FormattingEnabled = true;
            selectThumbnailQuality.Location = new Point(77, 342);
            selectThumbnailQuality.Name = "selectThumbnailQuality";
            selectThumbnailQuality.Size = new Size(350, 21);
            selectThumbnailQuality.TabIndex = 7;
            selectThumbnailQuality.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label2.Location = new Point(8, 345);
            label2.Name = "label2";
            label2.Size = new Size(69, 13);
            label2.TabIndex = 9;
            label2.Text = "Thumbnail:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 388);
            label3.Name = "label3";
            label3.Size = new Size(43, 13);
            label3.TabIndex = 10;
            label3.Text = "Video:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 76);
            label1.Name = "label1";
            label1.Size = new Size(63, 13);
            label1.TabIndex = 11;
            label1.Text = "Video Url:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(74, 188, 150);
            label4.Location = new Point(91, 20);
            label4.Name = "label4";
            label4.Size = new Size(337, 38);
            label4.TabIndex = 12;
            label4.Text = "Youtube Downloader";
            // 
            // pictureIcon
            // 
            pictureIcon.Anchor = AnchorStyles.Top;
            pictureIcon.Image = (Image)resources.GetObject("pictureIcon.Image");
            pictureIcon.Location = new Point(57, 23);
            pictureIcon.Name = "pictureIcon";
            pictureIcon.Size = new Size(32, 32);
            pictureIcon.TabIndex = 13;
            pictureIcon.TabStop = false;
            // 
            // panelWaitingForVideoData
            // 
            panelWaitingForVideoData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelWaitingForVideoData.BackColor = Color.FromArgb(74, 188, 150);
            panelWaitingForVideoData.Controls.Add(lblVideoStatus);
            panelWaitingForVideoData.Location = new Point(77, 134);
            panelWaitingForVideoData.Name = "panelWaitingForVideoData";
            panelWaitingForVideoData.Size = new Size(350, 182);
            panelWaitingForVideoData.TabIndex = 14;
            // 
            // lblVideoStatus
            // 
            lblVideoStatus.Dock = DockStyle.Fill;
            lblVideoStatus.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVideoStatus.Location = new Point(0, 0);
            lblVideoStatus.Name = "lblVideoStatus";
            lblVideoStatus.Size = new Size(350, 182);
            lblVideoStatus.TabIndex = 0;
            lblVideoStatus.Text = "Waiting for Video...";
            lblVideoStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 65);
            ClientSize = new Size(524, 421);
            Controls.Add(pictureIcon);
            Controls.Add(label4);
            Controls.Add(panelWaitingForVideoData);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDownloadThumbnail);
            Controls.Add(selectThumbnailQuality);
            Controls.Add(btnDownloadVideo);
            Controls.Add(lblTitle);
            Controls.Add(selectVideoQuality);
            Controls.Add(btnGetVideoData);
            Controls.Add(txtVideoUrl);
            Controls.Add(imgVideoThumbnail);
            ForeColor = SystemColors.ControlLightLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(540, 460);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Youtube Downloader";
            ((System.ComponentModel.ISupportInitialize)imgVideoThumbnail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureIcon).EndInit();
            panelWaitingForVideoData.ResumeLayout(false);
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
        private PictureBox pictureIcon;
        private Panel panelWaitingForVideoData;
        private Label lblVideoStatus;
    }
}
