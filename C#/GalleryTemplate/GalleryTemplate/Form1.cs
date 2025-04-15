using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GalleryTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadArtistsFromFolder();
        }

        private void LoadArtistsFromFolder()
        {
            string imagesPath = Path.Combine(Application.StartupPath, "Images");

            if (!Directory.Exists(imagesPath))
            {
                Directory.CreateDirectory(imagesPath);
                MessageBox.Show("Создана папка Images. Добавьте подпапки с художниками.");
                return;
            }

            string[] artistFolders = Directory.GetDirectories(imagesPath);
            foreach (string folder in artistFolders)
            {
                listBoxArtists.Items.Add(Path.GetFileName(folder));
            }
        }

        private void btnOpenGallery_Click(object sender, EventArgs e)
        {
            if (listBoxArtists.SelectedItem != null)
            {
                string selectedArtist = listBoxArtists.SelectedItem.ToString();
                GalleryForm gallery = new GalleryForm(selectedArtist);
                gallery.Show();
            }
            else
            {
                MessageBox.Show("Выберите художника.");
            }
        }
    }
}