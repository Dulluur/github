namespace GalleryTemplate
{
    partial class GalleryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalleryForm));
            labelName = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            buttonBack = new Button();
            buttonForward = new Button();
            buttonToMain = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(12, 18);
            labelName.Name = "labelName";
            labelName.Size = new Size(91, 21);
            labelName.TabIndex = 0;
            labelName.Text = "Художник";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 53);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 76);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 372);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonForward
            // 
            buttonForward.Location = new Point(93, 372);
            buttonForward.Name = "buttonForward";
            buttonForward.Size = new Size(75, 23);
            buttonForward.TabIndex = 4;
            buttonForward.Text = "Вперед";
            buttonForward.UseVisualStyleBackColor = true;
            buttonForward.Click += buttonForward_Click;
            // 
            // buttonToMain
            // 
            buttonToMain.Location = new Point(666, 372);
            buttonToMain.Name = "buttonToMain";
            buttonToMain.Size = new Size(122, 23);
            buttonToMain.TabIndex = 5;
            buttonToMain.Text = "На главную";
            buttonToMain.UseVisualStyleBackColor = true;
            buttonToMain.Click += buttonToMain_Click;
            // 
            // GalleryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonToMain);
            Controls.Add(buttonForward);
            Controls.Add(buttonBack);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(labelName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GalleryForm";
            Text = "GalleryForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button buttonBack;
        private Button buttonForward;
        private Button buttonToMain;
    }
}