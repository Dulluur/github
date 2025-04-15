namespace GalleryTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBoxArtists = new ListBox();
            btnOpenGallery = new Button();
            SuspendLayout();
            // 
            // listBoxArtists
            // 
            listBoxArtists.FormattingEnabled = true;
            listBoxArtists.ItemHeight = 15;
            listBoxArtists.Location = new Point(12, 12);
            listBoxArtists.Name = "listBoxArtists";
            listBoxArtists.Size = new Size(313, 199);
            listBoxArtists.TabIndex = 0;
            // 
            // btnOpenGallery
            // 
            btnOpenGallery.Location = new Point(12, 226);
            btnOpenGallery.Name = "btnOpenGallery";
            btnOpenGallery.Size = new Size(313, 29);
            btnOpenGallery.TabIndex = 1;
            btnOpenGallery.Text = "Открыть галерею";
            btnOpenGallery.UseVisualStyleBackColor = true;
            btnOpenGallery.Click += btnOpenGallery_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 264);
            Controls.Add(btnOpenGallery);
            Controls.Add(listBoxArtists);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main gallery";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxArtists;
        private Button btnOpenGallery;
    }
}
