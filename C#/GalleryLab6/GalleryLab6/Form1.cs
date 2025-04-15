using System;
using System.IO;
using System.Windows.Forms;

namespace GalleryLab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadArtists();
        }

        private void LoadArtists()
        {
            listBoxArtists.Items.Clear();

            string imagesPath = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(imagesPath))
            {
                Directory.CreateDirectory(imagesPath);
                MessageBox.Show("Папка Images создана. Добавьте подпапки с художниками.");
                return;
            }

            string[] artistFolders = Directory.GetDirectories(imagesPath);
            foreach (string folder in artistFolders)
            {
                listBoxArtists.Items.Add(Path.GetFileName(folder));
            }
        }

        private void listBoxArtists_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxArtists.SelectedItem != null)
            {
                string? selectedArtist = listBoxArtists.SelectedItem.ToString();
                if (selectedArtist != null)
                {
                    GalleryForm galleryForm = new GalleryForm(selectedArtist);
                    galleryForm.Show();
                    this.Hide();
                }
            }
        }
    }
}