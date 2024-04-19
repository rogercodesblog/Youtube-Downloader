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
            txtVideoUrl.Location = new Point(87, 33);
            txtVideoUrl.Name = "txtVideoUrl";
            txtVideoUrl.PlaceholderText = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            txtVideoUrl.Size = new Size(314, 23);
            txtVideoUrl.TabIndex = 1;
            txtVideoUrl.TabStop = false;
            // 
            // btnGetVideoData
            // 
            btnGetVideoData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetVideoData.Location = new Point(407, 33);
            btnGetVideoData.Name = "btnGetVideoData";
            btnGetVideoData.Size = new Size(85, 23);
            btnGetVideoData.TabIndex = 2;
            btnGetVideoData.TabStop = false;
            btnGetVideoData.Text = "Get Data";
            btnGetVideoData.UseVisualStyleBackColor = true;
            btnGetVideoData.Click += btnGetVideoData_Click;
            // 
            // selectVideoQuality
            // 
            selectVideoQuality.Enabled = false;
            selectVideoQuality.FormattingEnabled = true;
            selectVideoQuality.Location = new Point(87, 281);
            selectVideoQuality.Name = "selectVideoQuality";
            selectVideoQuality.Size = new Size(314, 23);
            selectVideoQuality.TabIndex = 3;
            selectVideoQuality.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(13, 63);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(107, 15);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Waiting for video...";
            lblTitle.Visible = false;
            // 
            // btnDownloadVideo
            // 
            btnDownloadVideo.Enabled = false;
            btnDownloadVideo.Location = new Point(407, 281);
            btnDownloadVideo.Name = "btnDownloadVideo";
            btnDownloadVideo.Size = new Size(85, 23);
            btnDownloadVideo.TabIndex = 5;
            btnDownloadVideo.TabStop = false;
            btnDownloadVideo.Text = "Download";
            btnDownloadVideo.UseVisualStyleBackColor = true;
            btnDownloadVideo.Click += btnDownloadVideo_Click;
            // 
            // imgVideoThumbnail
            // 
            imgVideoThumbnail.Location = new Point(106, 84);
            imgVideoThumbnail.Name = "imgVideoThumbnail";
            imgVideoThumbnail.Size = new Size(275, 155);
            imgVideoThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
            imgVideoThumbnail.TabIndex = 6;
            imgVideoThumbnail.TabStop = false;
            // 
            // btnDownloadThumbnail
            // 
            btnDownloadThumbnail.Enabled = false;
            btnDownloadThumbnail.Location = new Point(407, 252);
            btnDownloadThumbnail.Name = "btnDownloadThumbnail";
            btnDownloadThumbnail.Size = new Size(85, 23);
            btnDownloadThumbnail.TabIndex = 8;
            btnDownloadThumbnail.TabStop = false;
            btnDownloadThumbnail.Text = "Download";
            btnDownloadThumbnail.UseVisualStyleBackColor = true;
            btnDownloadThumbnail.Click += btnDownloadThumbnail_Click;
            // 
            // selectThumbnailQuality
            // 
            selectThumbnailQuality.Enabled = false;
            selectThumbnailQuality.FormattingEnabled = true;
            selectThumbnailQuality.Location = new Point(87, 253);
            selectThumbnailQuality.Name = "selectThumbnailQuality";
            selectThumbnailQuality.Size = new Size(314, 23);
            selectThumbnailQuality.TabIndex = 7;
            selectThumbnailQuality.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 256);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 9;
            label2.Text = "Thumbnail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 285);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 10;
            label3.Text = "Video:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 35);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 11;
            label1.Text = "Video Url:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 9);
            label4.Name = "label4";
            label4.Size = new Size(151, 15);
            label4.TabIndex = 12;
            label4.Text = "Youtube Video Downloader";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 321);
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
