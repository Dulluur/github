using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba1
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private double FunctionTrygolnik(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
        }

        private bool TochkaInTreygolnik(double px, double py)
        {
            double x1 = 0, y1 = 0;
            double x2 = 5, y2 = 0;
            double x3 = 2, y3 = 5;

            double mainArea = FunctionTrygolnik(x1, y1, x2, y2, x3, y3);
            double area1 = FunctionTrygolnik(px, py, x2, y2, x3, y3);
            double area2 = FunctionTrygolnik(x1, y1, px, py, x3, y3);
            double area3 = FunctionTrygolnik(x1, y1, x2, y2, px, py);

            return (area1 + area2 + area3) == mainArea;
        }


        private void checkButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                double px = double.Parse(textBoxPX.Text);
                double py = double.Parse(textBoxPY.Text);

                if (TochkaInTreygolnik(px, py))
                {
                    MessageBox.Show("Точка находится ВНУТРИ треугольника.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Точка находится ВНЕ треугольника.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода данных. Введите числовые координаты точки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About newAbout = new About();
            newAbout.Show();
            this.Hide();
        }
    }
}



