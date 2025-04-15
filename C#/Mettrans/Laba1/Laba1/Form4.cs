using System;
using System.Windows.Forms;
using Laba1.Libraries;

namespace Laba1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            StudentsProcessor.OpenFileAndShowResult(); 
        }


        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About newForm = new About();
            newForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Случайно добавил
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Случайно добавил
        }

    }
}
