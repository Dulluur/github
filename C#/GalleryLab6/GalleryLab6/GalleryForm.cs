using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GalleryLab6
{
    public partial class GalleryForm : Form
    {
        private string artistName;
        private string[] imagePaths = Array.Empty<string>();
        private TextBox textBoxBio;
        private PictureBox pictureBoxArt;
        private Label labelImageInfo;
        private Button button1;
        private Button button2;
        private Button button3;
        private int currentImageIndex = 0;

        public GalleryForm(string artist)
        {
            if (string.IsNullOrEmpty(artist))
                throw new ArgumentNullException(nameof(artist));

            InitializeComponent();
            artistName = artist;
            LoadArtistData();
        }

        private void LoadArtistData()
        {
            this.Text = "Галерея: " + artistName;

            string artistPath = Path.Combine(Application.StartupPath, "Images", artistName);

            // Загрузка биографии
            string bioPath = Path.Combine(artistPath, "bio.txt");
            textBoxBio.Text = File.Exists(bioPath) ? File.ReadAllText(bioPath) : "Биография не найдена.";

            // Загрузка изображений
            imagePaths = Directory.GetFiles(artistPath, "*.jpg");
            if (imagePaths.Length == 0)
                imagePaths = Directory.GetFiles(artistPath, "*.png");

            if (imagePaths.Length > 0)
            {
                ShowImage(0);
            }
            else
            {
                pictureBoxArt.Image = null;
                labelImageInfo.Text = "Изображения не найдены";
            }
        }

        private void ShowImage(int index)
        {
            if (index >= 0 && index < imagePaths.Length)
            {
                currentImageIndex = index;
                try
                {
                    pictureBoxArt.Image = Image.FromFile(imagePaths[index]);
                    labelImageInfo.Text = $"{currentImageIndex + 1} из {imagePaths.Length}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
                }
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            ShowImage(currentImageIndex - 1);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ShowImage(currentImageIndex + 1);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            textBoxBio = new TextBox();
            pictureBoxArt = new PictureBox();
            labelImageInfo = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArt).BeginInit();
            SuspendLayout();
            // 
            // textBoxBio
            // 
            textBoxBio.Location = new Point(8, 31);
            textBoxBio.Name = "textBoxBio";
            textBoxBio.Size = new Size(100, 23);
            textBoxBio.TabIndex = 0;
            // 
            // pictureBoxArt
            // 
            pictureBoxArt.Location = new Point(8, 60);
            pictureBoxArt.Name = "pictureBoxArt";
            pictureBoxArt.Size = new Size(100, 50);
            pictureBoxArt.TabIndex = 1;
            pictureBoxArt.TabStop = false;
            // 
            // labelImageInfo
            // 
            labelImageInfo.AutoSize = true;
            labelImageInfo.Location = new Point(8, 123);
            labelImageInfo.Name = "labelImageInfo";
            labelImageInfo.Size = new Size(38, 15);
            labelImageInfo.TabIndex = 2;
            labelImageInfo.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(8, 161);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(89, 161);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(170, 161);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // GalleryForm
            // 
            ClientSize = new Size(465, 502);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelImageInfo);
            Controls.Add(pictureBoxArt);
            Controls.Add(textBoxBio);
            Name = "GalleryForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxArt).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void GalleryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            else
            {
                new Form1().Show();
            }
        }
    }
}