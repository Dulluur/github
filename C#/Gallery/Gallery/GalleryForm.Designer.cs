namespace Gallery
{
    partial class GalleryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxBio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnToMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalleryForm));
            labelName = new Label();
            textBoxBio = new TextBox();
            pictureBox1 = new PictureBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnToMain = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelName.Location = new Point(12, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(500, 30);
            labelName.TabIndex = 5;
            labelName.Text = "Художник";
            // 
            // textBoxBio
            // 
            textBoxBio.Location = new Point(12, 42);
            textBoxBio.Multiline = true;
            textBoxBio.Name = "textBoxBio";
            textBoxBio.ReadOnly = true;
            textBoxBio.Size = new Size(500, 60);
            textBoxBio.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(12, 420);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Назад";
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(100, 420);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 1;
            btnNext.Text = "Вперед";
            btnNext.Click += btnNext_Click;
            // 
            // btnToMain
            // 
            btnToMain.Location = new Point(379, 420);
            btnToMain.Name = "btnToMain";
            btnToMain.Size = new Size(108, 23);
            btnToMain.TabIndex = 0;
            btnToMain.Text = "На главную";
            btnToMain.Click += btnToMain_Click;
            // 
            // GalleryForm
            // 
            ClientSize = new Size(524, 461);
            Controls.Add(btnToMain);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxBio);
            Controls.Add(labelName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GalleryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Галерея";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}