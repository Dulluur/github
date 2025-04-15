namespace StringFunctionsLab
{
    public partial class Laba2 : Form
    {
        StringFunctions StringFunctions = new StringFunctions();
        public Laba2()
        {
            InitializeComponent();
        }
        //1
        //CONCAT
        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = inputConcat1.Text;
            string s2 = inputConcat2.Text;

            resultTextBox.Text = StringFunctions.Concat(s1, s2);
        }
        //2
        //REVERSE
        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = richTextBox1.Text;

            resultLabelReverse.Text = StringFunctions.Reverse(s1);
        }
        //3
        //TRIM
        private void button3_Click(object sender, EventArgs e)
        {
            string s = richTextBox3.Text;

            resultLabelTrim.Text = StringFunctions.Trim(s);
            resultTrimBox.Text = StringFunctions.Trim(s);
        }
        //4
        //LEFT
        private void button4_Click(object sender, EventArgs e)
        {
            string s = richTextBoxLeft.Text;
            if (!int.TryParse(inputLeft.Text, out int l) || l < 0)
            {
                MessageBox.Show("Введите корректное положительное число");
                return;
            }

            resultLabelLeft.Text = StringFunctions.Left(s, l);
        }
        //5
        //RIGHT
        private void button5_Click(object sender, EventArgs e)
        {
            string s = richTextBoxRight.Text;

            if (!int.TryParse(inputRight.Text, out int n) || n < 0)
            {
                MessageBox.Show("Введите корректное положительное число");
                return;
            }
            resultLabelRight.Text = StringFunctions.Right(s, n);
        }
        //6
        //COPIES
        private void button6_Click(object sender, EventArgs e)
        {
            string s = richTextBoxCopies.Text;
            if (!int.TryParse(inputCopies.Text, out int n) || n < 0)
            {
                MessageBox.Show("Введите корректное положительное число");
                return;
            }

            resultLabelCopies.Text = StringFunctions.Copies(s, n);
        }
        //7
        //Insert
        private void button7_Click(object sender, EventArgs e)
        {
            string s1 = richTextBoxInsert1.Text;
            string s2 = richTextBoxInsert2.Text;

            if (!int.TryParse(inputInsert.Text, out int n) || n < 0)
            {
                MessageBox.Show("Введите корректное положительное число");
                return;
            }

            resultLabelInsert.Text = StringFunctions.Insert(s1, s2, n);
        }
        //8
        //Delete
        private void button8_Click(object sender, EventArgs e)
        {
            string s = richTextBoxDelete.Text;

            if (!int.TryParse(textBoxDeleteStart.Text, out int n) || n < 0)
            {
                MessageBox.Show("Введите корректное положительное число");
                return;
            }

            if (!int.TryParse(textBoxDeleteLength.Text, out int l) || n < 0)
            {
                MessageBox.Show("Введите корректное положительное число");
                return;
            }


            resultLabelDelete.Text = StringFunctions.Delete(s, n, l);
        }
        //9
        //StrCSpns
        private void button9_Click(object sender, EventArgs e)
        {
            string s = richTextBoxWord.Text;
            string s1 = richTextBoxWord2.Text;

            resultLabelWord.Text = StringFunctions.StrCSpn(s, s1);
        }

        //10
        //REPLACE
        private void button10_Click(object sender, EventArgs e)
        {
            string s = richTextBoxReplace.Text;
            string s1 = textBoxReplaceFind.Text;
            string s2 = textBoxReplaceReplace.Text;

            resultLabelReplace.Text = StringFunctions.Replace(s, s1, s2);
        }
    }
}
