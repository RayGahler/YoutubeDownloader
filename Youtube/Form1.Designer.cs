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
            LoadingText = new TextBox();
            downloadProgressBar = new ProgressBar();
            VideoOptions = new ListBox();
            AudioOptions = new ListBox();
            DownloadProgress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Thumbnail_Holder).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(258, 413);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchQuery
            // 
            SearchQuery.Location = new Point(41, 292);
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
            DownloadButton.Location = new Point(806, 518);
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
            Title.Location = new Point(738, 28);
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Size = new Size(266, 16);
            Title.TabIndex = 5;
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
            // downloadProgressBar
            // 
            downloadProgressBar.Location = new Point(792, 599);
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
            DownloadProgress.Location = new Point(714, 577);
            DownloadProgress.Name = "DownloadProgress";
            DownloadProgress.ReadOnly = true;
            DownloadProgress.Size = new Size(266, 16);
            DownloadProgress.TabIndex = 11;
            DownloadProgress.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 649);
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
        private TextBox LoadingText;
        private ProgressBar downloadProgressBar;
        private ListBox VideoOptions;
        private ListBox AudioOptions;
        private TextBox DownloadProgress;
    }
}
