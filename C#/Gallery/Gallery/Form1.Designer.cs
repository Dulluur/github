namespace Gallery
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxArtists;
        private System.Windows.Forms.Button btnOpenGallery;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

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
            listBoxArtists.Size = new Size(260, 169);
            listBoxArtists.TabIndex = 1;
            // 
            // btnOpenGallery
            // 
            btnOpenGallery.Location = new Point(12, 200);
            btnOpenGallery.Name = "btnOpenGallery";
            btnOpenGallery.Size = new Size(260, 30);
            btnOpenGallery.TabIndex = 0;
            btnOpenGallery.Text = "Открыть галерею";
            btnOpenGallery.UseVisualStyleBackColor = true;
            btnOpenGallery.Click += btnOpenGallery_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(284, 241);
            Controls.Add(btnOpenGallery);
            Controls.Add(listBoxArtists);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Галерея";
            ResumeLayout(false);
        }
    }
}