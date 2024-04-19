using System.Net.Http;
using System.Runtime.InteropServices.Marshalling;
using System.Text.RegularExpressions;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;
using static System.Net.WebRequestMethods;

namespace YoutubeDownloader
{
    public partial class MainForm : Form
    {
        private string OutputDirectory;
        private string NormalizedTitle;
        YoutubeClient YoutubeClient;
        YoutubeExplode.Videos.Video Video;
        List<YoutubeExplode.Videos.Streams.MuxedStreamInfo> MuxedStreamInfo;
        public MainForm()
        {
            InitializeComponent();
            SetOutputDirectory();
            YoutubeClient = new YoutubeClient();
        }

        private void btnGetVideoData_Click(object sender, EventArgs e)
        {
            GetVideoData(txtVideoUrl.Text);
        }

        private void btnDownloadThumbnail_Click(object sender, EventArgs e)
        {
            DownloadThumbnail();
        }

        private void btnDownloadVideo_Click(object sender, EventArgs e)
        {
            DownloadVideo();
        }

        //TODO: Add a CSV for saving configurations and a custom output directory
        private void SetOutputDirectory()
        {
            OutputDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private async void GetVideoData(string url)
        {
            btnGetVideoData.Enabled = false;
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("The url is cannot be empty", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnGetVideoData.Enabled = true;
                return;
            }

            //Regex pattern provided by Regexr.com
            if (!Regex.IsMatch(url, "^((?:https?:)?\\/\\/)?((?:www|m)\\.)?((?:youtube\\.com|youtu.be))(\\/(?:[\\w\\-]+\\?v=|embed\\/|v\\/)?)([\\w\\-]+)(\\S+)?$"))
            {
                MessageBox.Show("The provided video Url is not valid", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnGetVideoData.Enabled = true;
                return;
            }

            try
            {
                Video = await YoutubeClient.Videos.GetAsync(url);

                NormalizedTitle = string.Join("_", Video.Title.Split(Path.GetInvalidFileNameChars()));

                var streamManifest = await YoutubeClient.Videos.Streams.GetManifestAsync(Video.Id);

                MuxedStreamInfo = streamManifest.GetMuxedStreams().OrderByDescending(video => video.VideoQuality).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error ocurred; \n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGetVideoData.Enabled = true;
                return;
            }

            lblTitle.Text = NormalizedTitle;
            selectThumbnailQuality.DataSource = Video.Thumbnails;
            selectVideoQuality.DataSource = MuxedStreamInfo;
            imgVideoThumbnail.ImageLocation = Video.Thumbnails.FirstOrDefault().Url.Split("?").First();

            lblTitle.Visible = true;
            selectThumbnailQuality.Enabled = true;
            selectVideoQuality.Enabled = true;
            btnDownloadThumbnail.Enabled = true;
            btnDownloadVideo.Enabled = true;
            btnGetVideoData.Enabled = true;
        }
        //Todo;
        //Let user select file name, or add a (1) / (2) and so on at the end
        //Verify if a file of same name exists
        private async Task DownloadThumbnail()
        {
            btnDownloadThumbnail.Enabled = false;
            try
            {
                using(HttpClient httpClient = new HttpClient())
                {
                    var info = selectThumbnailQuality.SelectedItem as YoutubeExplode.Common.Thumbnail;

                    var stream = await httpClient.GetStreamAsync(info.Url);

                    //Todo; not all files are jpg, some of them are webp but still work, sort this out.

                    string outputFilePath = Path.Combine(OutputDirectory, $"{NormalizedTitle}.jpg");

                    using var outputStream = System.IO.File.Create(outputFilePath);

                    await stream.CopyToAsync(outputStream);

                    MessageBox.Show("File Downloaded!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error ocurred; \n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDownloadThumbnail.Enabled = true;
                return;
            }
            btnDownloadThumbnail.Enabled = true;
        }
        //Todo;
        //Let user select file name, or add a (1) / (2) and so on at the end
        //Verify if a file of same name exists
        private async Task DownloadVideo()
        {
            btnDownloadVideo.Enabled = false;
            try
            {
                using (HttpClient httpclient = new HttpClient())
                {
                    MuxedStreamInfo info = selectVideoQuality.SelectedItem as MuxedStreamInfo;

                    var stream = await httpclient.GetStreamAsync(info.Url);

                    string outputFilePath = Path.Combine(OutputDirectory, $"{NormalizedTitle}.{info.Container}");

                    using var outputStream = System.IO.File.Create(outputFilePath);

                    await stream.CopyToAsync(outputStream);

                    MessageBox.Show("File Downloaded!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error ocurred; \n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDownloadVideo.Enabled = true;
                return;
            }
            btnDownloadVideo.Enabled = true;
        }
    }
}
