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
            Download_Button = new Button();
            Title = new TextBox();
            AudioDownload = new Button();
            LoadingText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Thumbnail_Holder).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(279, 178);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchQuery
            // 
            SearchQuery.Location = new Point(62, 57);
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
            Thumbnail_Holder.Location = new Point(656, 57);
            Thumbnail_Holder.Name = "Thumbnail_Holder";
            Thumbnail_Holder.Size = new Size(430, 280);
            Thumbnail_Holder.TabIndex = 2;
            Thumbnail_Holder.TabStop = false;
            // 
            // Download_Button
            // 
            Download_Button.Location = new Point(738, 384);
            Download_Button.Name = "Download_Button";
            Download_Button.Size = new Size(75, 23);
            Download_Button.TabIndex = 4;
            Download_Button.Text = "Video";
            Download_Button.UseVisualStyleBackColor = true;
            Download_Button.Click += Download_Button_Click;
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
            // AudioDownload
            // 
            AudioDownload.Location = new Point(929, 384);
            AudioDownload.Name = "AudioDownload";
            AudioDownload.Size = new Size(75, 23);
            AudioDownload.TabIndex = 6;
            AudioDownload.Text = "Audio";
            AudioDownload.UseVisualStyleBackColor = true;
            AudioDownload.Click += AudioDownload_Click;
            // 
            // LoadingText
            // 
            LoadingText.BackColor = SystemColors.Control;
            LoadingText.BorderStyle = BorderStyle.None;
            LoadingText.Location = new Point(279, 321);
            LoadingText.Name = "LoadingText";
            LoadingText.ReadOnly = true;
            LoadingText.Size = new Size(75, 16);
            LoadingText.TabIndex = 7;
            LoadingText.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 649);
            Controls.Add(LoadingText);
            Controls.Add(AudioDownload);
            Controls.Add(Title);
            Controls.Add(Download_Button);
            Controls.Add(Thumbnail_Holder);
            Controls.Add(SearchQuery);
            Controls.Add(SearchButton);
            Name = "Form1";
            Text = "Form1";
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
        private Button Download_Button;
        private TextBox Title;
        private Button AudioDownload;
        private TextBox LoadingText;
    }
}
