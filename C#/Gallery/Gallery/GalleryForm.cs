using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gallery
{
    public partial class GalleryForm : Form
    {
        private string artistName;
        private ArtistData artistData;
        private int currentIndex = 0;

        public GalleryForm(string name, ArtistData data)
        {
            InitializeComponent();
            artistName = name;
            artistData = data;

            labelName.Text = artistName;
            textBoxBio.Text = artistData.Bio;
            ShowImage();
        }

        private void ShowImage()
        {
            if (artistData.ImagePaths.Count > 0 && File.Exists(artistData.ImagePaths[currentIndex]))
            {
                pictureBox1.Image = Image.FromFile(artistData.ImagePaths[currentIndex]);
            }
            else
            {
                pictureBox1.Image = null;
                MessageBox.Show("Файл изображения не найден.");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < artistData.ImagePaths.Count - 1)
            {
                currentIndex++;
                ShowImage();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowImage();
            }
        }

        private void btnToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}