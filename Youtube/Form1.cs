using YoutubeExplode;
using YoutubeExplode.Common;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Webp;
using YoutubeExplode.Videos;
using FFMpegCore;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using YoutubeExplode.Videos.Streams;

namespace Youtube
{
    public partial class Form1 : Form
    {
        private YoutubeClient client = new YoutubeClient();
        private Video CurrentVideo;
        private int selectedVideoIndex = -1;
        private int selectedAudioIndex = -1;
        List<VideoOnlyStreamInfo> videoStreams;
        List<AudioOnlyStreamInfo> audioStreams;
        string audioSavePath;
        string videoSavePath;
        public Form1()
        {
            InitializeComponent();
            this.SearchQuery.PlaceholderText = "Enter Youtube Link";
            this.DownloadButton.Visible = false;
            this.Thumbnail_Holder.Visible = false;
            this.Title.Visible = false;
            this.LoadingText.Text = "Loading";
            this.LoadingText.Visible = false;

            this.audioSavePath = Directory.GetCurrentDirectory() + "/Audios/";
            this.videoSavePath = Directory.GetCurrentDirectory() + "/Videos/";

            this.AudioSaveDirectory.Text = audioSavePath;
            this.VideoSaveDirectory.Text = videoSavePath;




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("./Videos"))
            {
                Directory.CreateDirectory("Videos");
            }

            if (!Directory.Exists("./Audios"))
            {
                Directory.CreateDirectory("Audios");
            }
            if (!Directory.Exists("./Temp"))
            {
                Directory.CreateDirectory("Temp");
            }

        }



        private async Task<System.Drawing.Image> getThumbnail(string URL)
        {

            ImageConverter converter = new ImageConverter();
            HttpClient Hclient = new HttpClient();
            Hclient.BaseAddress = new Uri(URL);
            var Result = await Hclient.GetStreamAsync(Hclient.BaseAddress);
            WebpDecoder decoder = WebpDecoder.Instance;
            WebpConfigurationModule config = new WebpConfigurationModule();
            MemoryStream MemStream = new MemoryStream();
            SixLabors.ImageSharp.Image.Load(Result).SaveAsPng(MemStream);

            return System.Drawing.Image.FromStream(MemStream);

            //var Thumbnail = converter.ConvertFrom(Pic) as Image;


        }


        private async void SearchButton_Click(object sender, EventArgs e)
        {
            this.DownloadButton.Visible = false;
            this.Thumbnail_Holder.Visible = false;
            this.Title.Visible = false;
            this.AuthorText.Visible = false;
            this.LoadingText.Visible = true;
            this.VideoOptions.Items.Clear();
            this.AudioOptions.Items.Clear();

            this.VideoOptions.Items.Add("Loading...");
            this.AudioOptions.Items.Add("Loading...");

            string SearchQuery = this.SearchQuery.Text;

            if (!SearchQuery.Contains(".com") && !SearchQuery.Contains(".be"))
            {
                this.SearchQuery.Text = "Invalid YouTube Link";
                this.LoadingText.Visible = false;

                return;
            }
            var video = await client.Videos.GetAsync(SearchQuery);
            this.CurrentVideo = video;
            var ThumbnailDetails = video.Thumbnails.GetWithHighestResolution();
            string ThumbnailLink;
            System.Drawing.Image Thumbnail;

            if (ThumbnailDetails != null)
            {
                ThumbnailLink = ThumbnailDetails.Url;
                if (ThumbnailLink.Contains(".webp"))
                {
                    ThumbnailLink.Replace("webp", "png");
                }


                //this.SearchQuery.Text = ThumbnailDetails.Url;
                Thumbnail = await getThumbnail(ThumbnailLink);
                var resize = new Bitmap(Thumbnail_Holder.Width, Thumbnail_Holder.Height);
                using (Graphics graphics = Graphics.FromImage(resize))
                {
                    graphics.DrawImage(Thumbnail, 0, 0, Thumbnail_Holder.Width, Thumbnail_Holder.Height);
                }
                this.Thumbnail_Holder.Image = resize;

            }

            this.Title.Text = video.Title;
            this.AuthorText.Text = video.Author.ToString();
            this.DurationText.Text = video.Duration.ToString();
            this.DownloadButton.Visible = true;
            this.Thumbnail_Holder.Visible = true;
            this.Title.Visible = true;
            this.LoadingText.Visible = false;



            var Manifest = await client.Videos.Streams.GetManifestAsync(CurrentVideo.Url);

            videoStreams = Manifest.GetVideoOnlyStreams().ToList();

            this.VideoOptions.Items.Clear();
            this.AudioOptions.Items.Clear();
            this.SelectedAudioOption.Text = "No Option";
            this.SelectedVideoOption.Text = "No Option";

            foreach (var stream in videoStreams)
            {
                string streamData = stream.ToString();
                this.VideoOptions.Items.Add(streamData);
            }
            this.VideoOptions.Items.Add("No Option");

            audioStreams = Manifest.GetAudioOnlyStreams().ToList();

            foreach (var stream in audioStreams)
            {
                string streamData = stream.ToString() + " " + stream.AudioCodec + " " + stream.Bitrate;
                this.AudioOptions.Items.Add(streamData);
            }
            this.AudioOptions.Items.Add("No Option");

        }





        private void VideoOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVideoIndex = this.VideoOptions.SelectedIndex;
            this.SelectedVideoOption.Text = VideoOptions.Items[selectedVideoIndex].ToString();

        }

        private void AudioOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAudioIndex = this.AudioOptions.SelectedIndex;
            this.SelectedAudioOption.Text = AudioOptions.Items[selectedAudioIndex].ToString();

        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            var selectedVideoStream = selectedVideoIndex >= 0 && selectedVideoIndex < videoStreams.Count ? videoStreams[selectedVideoIndex] : null;
            var selectedAudioStream = selectedAudioIndex >= 0 && selectedAudioIndex < audioStreams.Count ? audioStreams[selectedAudioIndex] : null;


            string AudioPath = $"{audioSavePath}/{CurrentVideo.Title.Replace("|", "").Replace("\"", "").Replace("&", "").Replace("\\", "")}.mp3";
            string VideoPath = $"{videoSavePath}/{CurrentVideo.Title.Replace("|", "").Replace("\"", "").Replace("&", "").Replace("\\", "")}.mp4";

            if(AudioPath == VideoPath)
            {
                throw (new Exception("Sigma"));
            }

            var progress = new Progress<double>(p =>
            {
                // p is a value between 0.0 and 1.0
                this.downloadProgressBar.Invoke(() =>
                {
                    this.downloadProgressBar.Value = (int)(p * 100);
                });
            });

            DownloadProgress.Text = "Downloading video...";
            if (selectedVideoStream != null && selectedAudioStream != null)
            {

                var VideoProg = new Progress<double>(p =>
                {
                    // p is a value between 0.0 and 1.0
                    this.downloadProgressBar.Invoke(() =>
                    {
                        this.downloadProgressBar.Value = (int)(p * 100);
                    });
                });
                var AudioProg = new Progress<double>(p =>
                {
                    // p is a value between 0.0 and 1.0
                    this.downloadProgressBar.Invoke(() =>
                    {
                        this.downloadProgressBar.Value = (int)(p * 100);
                    });
                });

                await this.client.Videos.Streams.DownloadAsync(selectedVideoStream, $"./Temp/CurrentVideoOnly{selectedVideoStream.Container.Name}", VideoProg);

                DownloadProgress.Text = "Downloading audio...";
                await this.client.Videos.Streams.DownloadAsync(selectedAudioStream, $"./Temp/CurrentAudioOnly{selectedAudioStream.Container.Name}", AudioProg);

                DownloadProgress.Text = "Muxing files...";
                await FFMpegArguments.FromFileInput($"./Temp/CurrentVideoOnly{selectedVideoStream.Container.Name}").
                    AddFileInput($"./Temp/CurrentAudioOnly{selectedAudioStream.Container.Name}").
                    OutputToFile(VideoPath, true,
                    options => options
                    .WithVideoCodec("copy")
                    .WithAudioCodec("libmp3lame")).NotifyOnProgress(percent =>
                    {
                        // percent is a double between 0.0 and 1.0
                        this.downloadProgressBar.Invoke(() =>
                        {
                            if ((int)(percent * .01) > 100)
                            {
                                this.downloadProgressBar.Value = 100;
                            }
                            else
                                this.downloadProgressBar.Value = (int)(percent * .01);
                        });
                    }, TimeSpan.FromMilliseconds(500)) // update every 500ms

                    .ProcessAsynchronously();
                File.Delete($"./Temp/CurrentVideoOnly{selectedVideoStream.Container.Name}");
                DownloadProgress.Text = "Finished!";
            }
            else if (selectedVideoStream != null)
            {
                await this.client.Videos.Streams.DownloadAsync(selectedVideoStream, $"./Videos/Temp{CurrentVideo.Title.Replace("|", "").Replace("\"", "").Replace("&", "").Replace("\\", "")}.{selectedVideoStream.Container.Name}");
                if (File.Exists(VideoPath))
                {
                    File.Delete(VideoPath);
                }
                DownloadProgress.Text = "Applying Codec...";

                await FFMpegArguments.FromFileInput($"./Videos/Temp{CurrentVideo.Title.Replace("|", "").Replace("\"", "").Replace("&", "").Replace("\\", "")}.{selectedVideoStream.Container.Name}").
                    OutputToFile(VideoPath, true,
                    options => options.WithVideoCodec("copy")).NotifyOnProgress(percent =>
                    {
                        // percent is a double between 0.0 and 1.0
                        this.downloadProgressBar.Invoke(() =>
                        {
                            if ((int)(percent * .01) > 100)
                            {
                                this.downloadProgressBar.Value = 100;
                            }
                            else
                                this.downloadProgressBar.Value = (int)(percent * .01);
                        });
                    }, TimeSpan.FromMilliseconds(500)) // update every 500ms

                    .ProcessAsynchronously();
                DownloadProgress.Text = "Finished!";

                File.Delete($"./Videos/Temp{CurrentVideo.Title.Replace("|", "").Replace("\"", "").Replace("&", "").Replace("\\", "")}.{selectedVideoStream.Container.Name}");

            }

            else if (selectedAudioStream != null)
            {
                DownloadProgress.Text = "Downloading audio...";
                await this.client.Videos.Streams.DownloadAsync(selectedAudioStream, $"./Audios/Temp{CurrentVideo.Title.Replace("|", "").Replace("\"", "").Replace("&", "").Replace("\\", "")}.{selectedAudioStream.Container.Name}");
                if (File.Exists(AudioPath))
                {
                    File.Delete(AudioPath);
                }
                DownloadProgress.Text = "Applying Codec...";
                await FFMpegArguments.FromFileInput($"./Audios/Temp{CurrentVideo.Title.Replace("|", "").Replace("\"", "").Replace("&", "").Replace("\\", "")}.{selectedAudioStream.Container.Name}").
                    OutputToFile(AudioPath, true,
                    options => options.WithAudioCodec("libmp3lame")).NotifyOnProgress(percent =>
                    {
                        // percent is a double between 0.0 and 1.0
                        this.downloadProgressBar.Invoke(() =>
                        {
                            if ((int)(percent * .01) > 100)
                            {
                                this.downloadProgressBar.Value = 100;
                            }
                            else
                                this.downloadProgressBar.Value = (int)(percent * .01);
                        });
                    }, TimeSpan.FromMilliseconds(500))
                    .ProcessAsynchronously();
                File.Delete($"./Audios/Temp{CurrentVideo.Title.Replace("|", "").Replace("\"", "").Replace("&", "").Replace("\\", "")}.{selectedAudioStream.Container.Name}");
            }

            this.downloadProgressBar.Value = 0;

        }

        private void ChangeFileLocation_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            this.audioSavePath = folderBrowserDialog1.SelectedPath;
            this.videoSavePath = folderBrowserDialog1.SelectedPath;

            this.AudioSaveDirectory.Text = audioSavePath;
        }

        private void ChangeVideoFileLocation_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            this.videoSavePath = folderBrowserDialog1.SelectedPath;

            this.VideoSaveDirectory.Text = videoSavePath;
        }


    }
}
