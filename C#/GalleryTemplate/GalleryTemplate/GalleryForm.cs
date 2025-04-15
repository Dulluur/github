using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GalleryTemplate
{
    public partial class GalleryForm : Form
    {
        private string artistName;
        private string[] imagePaths;
        private int currentIndex = 0;

        public GalleryForm(string artist)
        {
            InitializeComponent();
            artistName = artist;
            LoadArtistData();
        }

        private void LoadArtistData()
        {
            string artistPath = Path.Combine(Application.StartupPath, "Images", artistName);

            string bioFile = Path.Combine(artistPath, "bio.txt");
            textBox1.Text = File.Exists(bioFile) ? File.ReadAllText(bioFile) : "Биография не найдена";

            imagePaths = Directory.GetFiles(artistPath, "*.jpg");
            if (imagePaths.Length == 0)
                imagePaths = Directory.GetFiles(artistPath, "*.png");

            labelName.Text = artistName;
            ShowImage();
        }

        private void ShowImage()
        {
            if (imagePaths != null && imagePaths.Length > 0 && currentIndex < imagePaths.Length)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(imagePaths[currentIndex]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (currentIndex < imagePaths.Length - 1)
            {
                currentIndex++;
                ShowImage();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowImage();
            }
        }

        private void buttonToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}