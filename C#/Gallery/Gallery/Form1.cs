using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gallery
{
    public partial class Form1 : Form
    {
        private Dictionary<string, ArtistData> artists;

        public Form1()
        {
            InitializeComponent();

            artists = new Dictionary<string, ArtistData>
            {
                ["Ван Гог"] = new ArtistData
                {
                    Bio = "Винсент Ван Гог — нидерландский художник-постимпрессионист.",
                    ImagePaths = new List<string>
                    {
                        "Resources/van_gogh_1.jpg",
                        "Resources/van_gogh_2.png",
                        "Resources/van_gogh_3.png"
                    }
                },
                ["Леонардо да Винчи"] = new ArtistData
                {
                    Bio = "Леонардо да Винчи — итальянский художник, ученый, инженер.",
                    ImagePaths = new List<string>
                    {
                        "Resources/da_vinci_1.jpg",
                        "Resources/da_vinci_2.jpg",
                        "Resources/da_vinci_3.jpg"
                    }
                }
            };

            listBoxArtists.Items.AddRange(artists.Keys.ToArray());
        }

        private void btnOpenGallery_Click(object sender, EventArgs e)
        {
            if (listBoxArtists.SelectedItem != null)
            {
                string selectedArtist = listBoxArtists.SelectedItem.ToString();
                var artistData = artists[selectedArtist];

                GalleryForm gallery = new GalleryForm(selectedArtist, artistData);
                gallery.Show();
            }
            else
            {
                MessageBox.Show("Выберите художника.");

            }
        }
    }
}