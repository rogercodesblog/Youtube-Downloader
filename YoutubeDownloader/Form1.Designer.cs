namespace YoutubeDownloader
{
    partial class Form1
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
            SuspendLayout();
            // 
            // txtVideoUrl
            // 
            txtVideoUrl.Location = new Point(12, 12);
            txtVideoUrl.Name = "txtVideoUrl";
            txtVideoUrl.PlaceholderText = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            txtVideoUrl.Size = new Size(329, 23);
            txtVideoUrl.TabIndex = 1;
            txtVideoUrl.TabStop = false;
            // 
            // btnGetVideoData
            // 
            btnGetVideoData.Location = new Point(347, 12);
            btnGetVideoData.Name = "btnGetVideoData";
            btnGetVideoData.Size = new Size(75, 23);
            btnGetVideoData.TabIndex = 2;
            btnGetVideoData.TabStop = false;
            btnGetVideoData.Text = "Get Data";
            btnGetVideoData.UseVisualStyleBackColor = true;
            btnGetVideoData.Click += btnGetVideoData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 336);
            Controls.Add(btnGetVideoData);
            Controls.Add(txtVideoUrl);
            Name = "Form1";
            Text = "Youtube Downloader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVideoUrl;
        private Button btnGetVideoData;
    }
}
