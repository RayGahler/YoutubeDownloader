using System.Diagnostics;
using System.Net;
using YoutubeExplode;
using YoutubeExplode.Common;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.Drawing;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace Youtube
{
    public partial class Form1 : Form
    {
        private YoutubeClient client = new YoutubeClient();
        private Video CurrentVideo;
        public Form1()
        {
            InitializeComponent();
            this.SearchQuery.PlaceholderText = "Enter Youtube Link";
            this.Download_Button.Visible = false;
            this.AudioDownload.Visible = false;
            this.Thumbnail_Holder.Visible = false;
            this.Title.Visible = false;
            this.LoadingText.Text = "Loading";
            this.LoadingText.Visible = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async Task<System.Drawing.Image> getThumbnail(string URL)
        {

            ImageConverter converter = new ImageConverter();
            HttpClient Hclient = new HttpClient();
            Hclient.BaseAddress = new Uri(URL);
            var Result = await Hclient.GetStreamAsync(Hclient.BaseAddress);
            WebpDecoder decoder = new WebpDecoder();
            WebpConfigurationModule config = new WebpConfigurationModule();
            MemoryStream MemStream = new MemoryStream();
            SixLabors.ImageSharp.Image.Load(Result).SaveAsPng(MemStream);

            return System.Drawing.Image.FromStream(MemStream);

            //var Thumbnail = converter.ConvertFrom(Pic) as Image;


        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            this.Download_Button.Visible = false;
            this.AudioDownload.Visible = false;
            this.Thumbnail_Holder.Visible = false;
            this.Title.Visible = false;
            this.LoadingText.Visible = true;


            string SearchQuery = this.SearchQuery.Text;
            if (!SearchQuery.Contains(".com") && !SearchQuery.Contains(".be"))
            {
                this.SearchQuery.Text = "Invalid YouTube Link";
            }
            var video = await client.Videos.GetAsync(SearchQuery);
            this.CurrentVideo = video;
            var ThumbnailDetails = video.Thumbnails.GetWithHighestResolution();
            string ThumbnailLink = null;
            System.Drawing.Image Thumbnail = null;

            if (ThumbnailDetails != null)
            {
                ThumbnailLink = ThumbnailDetails.Url;
                if (ThumbnailLink.Contains(".webp"))
                {
                    ThumbnailLink.Replace("webp", "png");
                }
               
            }

            if (ThumbnailDetails != null)
            {
                //this.SearchQuery.Text = ThumbnailDetails.Url;
                Thumbnail = await getThumbnail(ThumbnailLink);
                var resize = new Bitmap(Thumbnail_Holder.Width, Thumbnail_Holder.Height);
                using (Graphics graphics = Graphics.FromImage(resize))
                {
                    graphics.DrawImage(Thumbnail, 0, 0, Thumbnail_Holder.Width, Thumbnail_Holder.Height);
                }
                this.Thumbnail_Holder.Image = resize;

            }
            Title.Text = video.Title;
            this.Download_Button.Visible = true;
            this.AudioDownload.Visible = true;
            this.Thumbnail_Holder.Visible = true;
            this.Title.Visible = true;
            this.LoadingText.Visible = false;

        }

        private async void Download_Button_Click(object sender, EventArgs e)
        {
            string Url = CurrentVideo.Url;
            string VideoName = CurrentVideo.Title;
            var Manifest = await client.Videos.Streams.GetManifestAsync(Url);
            var thing = Manifest.GetMuxedStreams().FirstOrDefault();
            if (!Directory.Exists("./Videos"))
            {
                Directory.CreateDirectory("Videos");
            }
            await client.Videos.Streams.DownloadAsync(thing, "./Videos\\" + VideoName.Replace("|", "").Replace("\"", "").Replace("&", "").Replace("\\", "") + ".mp4");
        }

        private async void AudioDownload_Click(object sender, EventArgs e)
        {
            string Url = CurrentVideo.Url;
            string VideoName = CurrentVideo.Title;
            var Manifest = await client.Videos.Streams.GetManifestAsync(Url);
            var thing = Manifest.GetAudioOnlyStreams().FirstOrDefault();
            if (!Directory.Exists("./Audios"))
            {
                Directory.CreateDirectory("Audios");
            }
            await client.Videos.Streams.DownloadAsync(thing, "./Audios\\" + VideoName.Replace("|","").Replace("\"", "").Replace("&","").Replace("\\","") + ".mp3");
        }
    }
}
