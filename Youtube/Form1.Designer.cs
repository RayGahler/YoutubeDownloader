namespace Youtube
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
            components = new System.ComponentModel.Container();
            SearchButton = new Button();
            SearchQuery = new TextBox();
            imageList1 = new ImageList(components);
            Thumbnail_Holder = new PictureBox();
            DownloadButton = new Button();
            Title = new TextBox();
            downloadProgressBar = new ProgressBar();
            VideoOptions = new ListBox();
            AudioOptions = new ListBox();
            DownloadProgress = new TextBox();
            AuthorText = new TextBox();
            LoadingText = new TextBox();
            DurationText = new TextBox();
            SelectedVideoOption = new TextBox();
            SelectedAudioOption = new TextBox();
            AudioSaveDirectory = new TextBox();
            ChangeAudioFileLocation = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ChangeVideoFileLocation = new Button();
            VideoSaveDirectory = new TextBox();
            VideoThing = new TextBox();
            AudioThing = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Thumbnail_Holder).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(258, 133);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchQuery
            // 
            SearchQuery.Location = new Point(38, 63);
            SearchQuery.Name = "SearchQuery";
            SearchQuery.Size = new Size(530, 23);
            SearchQuery.TabIndex = 1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Thumbnail_Holder
            // 
            Thumbnail_Holder.Location = new Point(605, 28);
            Thumbnail_Holder.Name = "Thumbnail_Holder";
            Thumbnail_Holder.Size = new Size(468, 309);
            Thumbnail_Holder.TabIndex = 2;
            Thumbnail_Holder.TabStop = false;
            // 
            // DownloadButton
            // 
            DownloadButton.Location = new Point(800, 518);
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new Size(75, 23);
            DownloadButton.TabIndex = 4;
            DownloadButton.Text = "Download";
            DownloadButton.UseVisualStyleBackColor = true;
            DownloadButton.Click += DownloadButton_Click;
            // 
            // Title
            // 
            Title.BorderStyle = BorderStyle.None;
            Title.Location = new Point(155, 218);
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Size = new Size(266, 16);
            Title.TabIndex = 5;
            Title.TextAlign = HorizontalAlignment.Center;
            // 
            // downloadProgressBar
            // 
            downloadProgressBar.Location = new Point(784, 613);
            downloadProgressBar.Name = "downloadProgressBar";
            downloadProgressBar.Size = new Size(114, 23);
            downloadProgressBar.TabIndex = 8;
            // 
            // VideoOptions
            // 
            VideoOptions.FormattingEnabled = true;
            VideoOptions.ItemHeight = 15;
            VideoOptions.Location = new Point(605, 385);
            VideoOptions.Name = "VideoOptions";
            VideoOptions.Size = new Size(207, 94);
            VideoOptions.TabIndex = 9;
            VideoOptions.SelectedIndexChanged += VideoOptions_SelectedIndexChanged;
            // 
            // AudioOptions
            // 
            AudioOptions.FormattingEnabled = true;
            AudioOptions.ItemHeight = 15;
            AudioOptions.Location = new Point(866, 385);
            AudioOptions.Name = "AudioOptions";
            AudioOptions.Size = new Size(207, 94);
            AudioOptions.TabIndex = 10;
            AudioOptions.SelectedIndexChanged += AudioOptions_SelectedIndexChanged;
            // 
            // DownloadProgress
            // 
            DownloadProgress.BorderStyle = BorderStyle.None;
            DownloadProgress.Location = new Point(708, 591);
            DownloadProgress.Name = "DownloadProgress";
            DownloadProgress.ReadOnly = true;
            DownloadProgress.Size = new Size(266, 16);
            DownloadProgress.TabIndex = 11;
            DownloadProgress.TextAlign = HorizontalAlignment.Center;
            // 
            // AuthorText
            // 
            AuthorText.BorderStyle = BorderStyle.None;
            AuthorText.Location = new Point(155, 255);
            AuthorText.Name = "AuthorText";
            AuthorText.ReadOnly = true;
            AuthorText.Size = new Size(266, 16);
            AuthorText.TabIndex = 12;
            AuthorText.TextAlign = HorizontalAlignment.Center;
            // 
            // LoadingText
            // 
            LoadingText.BackColor = SystemColors.Control;
            LoadingText.BorderStyle = BorderStyle.None;
            LoadingText.Location = new Point(258, 321);
            LoadingText.Name = "LoadingText";
            LoadingText.ReadOnly = true;
            LoadingText.Size = new Size(75, 16);
            LoadingText.TabIndex = 7;
            LoadingText.TextAlign = HorizontalAlignment.Center;
            // 
            // DurationText
            // 
            DurationText.BackColor = SystemColors.Control;
            DurationText.BorderStyle = BorderStyle.None;
            DurationText.Location = new Point(800, 343);
            DurationText.Name = "DurationText";
            DurationText.ReadOnly = true;
            DurationText.Size = new Size(75, 16);
            DurationText.TabIndex = 13;
            DurationText.TextAlign = HorizontalAlignment.Center;
            // 
            // SelectedVideoOption
            // 
            SelectedVideoOption.BackColor = SystemColors.Control;
            SelectedVideoOption.BorderStyle = BorderStyle.None;
            SelectedVideoOption.Location = new Point(605, 547);
            SelectedVideoOption.Name = "SelectedVideoOption";
            SelectedVideoOption.ReadOnly = true;
            SelectedVideoOption.Size = new Size(207, 16);
            SelectedVideoOption.TabIndex = 14;
            SelectedVideoOption.TextAlign = HorizontalAlignment.Center;
            // 
            // SelectedAudioOption
            // 
            SelectedAudioOption.BackColor = SystemColors.Control;
            SelectedAudioOption.BorderStyle = BorderStyle.None;
            SelectedAudioOption.Location = new Point(866, 547);
            SelectedAudioOption.Name = "SelectedAudioOption";
            SelectedAudioOption.ReadOnly = true;
            SelectedAudioOption.Size = new Size(207, 16);
            SelectedAudioOption.TabIndex = 15;
            SelectedAudioOption.TextAlign = HorizontalAlignment.Center;
            // 
            // AudioSaveDirectory
            // 
            AudioSaveDirectory.Location = new Point(38, 498);
            AudioSaveDirectory.Name = "AudioSaveDirectory";
            AudioSaveDirectory.Size = new Size(465, 23);
            AudioSaveDirectory.TabIndex = 16;
            // 
            // ChangeAudioFileLocation
            // 
            ChangeAudioFileLocation.Location = new Point(509, 498);
            ChangeAudioFileLocation.Name = "ChangeAudioFileLocation";
            ChangeAudioFileLocation.Size = new Size(75, 23);
            ChangeAudioFileLocation.TabIndex = 17;
            ChangeAudioFileLocation.Text = "Change";
            ChangeAudioFileLocation.UseVisualStyleBackColor = true;
            ChangeAudioFileLocation.Click += ChangeFileLocation_Click;
            // 
            // ChangeVideoFileLocation
            // 
            ChangeVideoFileLocation.Location = new Point(509, 584);
            ChangeVideoFileLocation.Name = "ChangeVideoFileLocation";
            ChangeVideoFileLocation.Size = new Size(75, 23);
            ChangeVideoFileLocation.TabIndex = 19;
            ChangeVideoFileLocation.Text = "Change";
            ChangeVideoFileLocation.UseVisualStyleBackColor = true;
            ChangeVideoFileLocation.Click += ChangeVideoFileLocation_Click;
            // 
            // VideoSaveDirectory
            // 
            VideoSaveDirectory.Location = new Point(38, 584);
            VideoSaveDirectory.Name = "VideoSaveDirectory";
            VideoSaveDirectory.Size = new Size(465, 23);
            VideoSaveDirectory.TabIndex = 18;
            // 
            // VideoThing
            // 
            VideoThing.BackColor = SystemColors.Control;
            VideoThing.BorderStyle = BorderStyle.None;
            VideoThing.Location = new Point(244, 562);
            VideoThing.Name = "VideoThing";
            VideoThing.ReadOnly = true;
            VideoThing.Size = new Size(75, 16);
            VideoThing.TabIndex = 20;
            VideoThing.Text = "Videos";
            VideoThing.TextAlign = HorizontalAlignment.Center;
            // 
            // AudioThing
            // 
            AudioThing.BackColor = SystemColors.Control;
            AudioThing.BorderStyle = BorderStyle.None;
            AudioThing.Location = new Point(244, 476);
            AudioThing.Name = "AudioThing";
            AudioThing.ReadOnly = true;
            AudioThing.Size = new Size(75, 16);
            AudioThing.TabIndex = 21;
            AudioThing.Text = "Audios";
            AudioThing.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 649);
            Controls.Add(AudioThing);
            Controls.Add(VideoThing);
            Controls.Add(ChangeVideoFileLocation);
            Controls.Add(VideoSaveDirectory);
            Controls.Add(ChangeAudioFileLocation);
            Controls.Add(AudioSaveDirectory);
            Controls.Add(SelectedAudioOption);
            Controls.Add(SelectedVideoOption);
            Controls.Add(DurationText);
            Controls.Add(AuthorText);
            Controls.Add(DownloadProgress);
            Controls.Add(AudioOptions);
            Controls.Add(VideoOptions);
            Controls.Add(downloadProgressBar);
            Controls.Add(LoadingText);
            Controls.Add(Title);
            Controls.Add(DownloadButton);
            Controls.Add(Thumbnail_Holder);
            Controls.Add(SearchQuery);
            Controls.Add(SearchButton);
            Name = "Form1";
            Text = "Youtube Downloader";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Thumbnail_Holder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox SearchQuery;
        private ImageList imageList1;
        private PictureBox Thumbnail_Holder;
        private Button DownloadButton;
        private TextBox Title;
        private ProgressBar downloadProgressBar;
        private ListBox VideoOptions;
        private ListBox AudioOptions;
        private TextBox DownloadProgress;
        private TextBox AuthorText;
        private TextBox LoadingText;
        private TextBox DurationText;
        private TextBox SelectedVideoOption;
        private TextBox SelectedAudioOption;
        private TextBox AudioSaveDirectory;
        private Button ChangeAudioFileLocation;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button1;
        private TextBox textBox1;
        private TextBox VideoSaveDirectory;
        private Button ChangeVideoFileLocation;
        private TextBox VideoThing;
        private TextBox AudioThing;
    }
}
