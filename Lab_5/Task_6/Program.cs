using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Task_6
{
    public class Program : Form
    {
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;

        public Program()
        {
            InitializeComponents(); // Ініціалізуємо компоненти форми
            OnFormLoad();
        }

        private void OnFormLoad()
        {
            this.Size = new System.Drawing.Size(750, 500);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            try
            {
                pictureBox1.Image = Image.FromFile("C:\\Wallpers\\1.jpg");
                pictureBox2.Image = Image.FromFile("C:\\Wallpers\\2.jpg");
                pictureBox3.Image = Image.FromFile("C:\\Wallpers\\3.jpg");
                pictureBox4.Image = Image.FromFile("C:\\Wallpers\\4.jpg");
                pictureBox5.Image = Image.FromFile("C:\\Wallpers\\5.jpg");
                pictureBox6.Image = Image.FromFile("C:\\Wallpers\\7.jpg");
                pictureBox7.Image = Image.FromFile("C:\\Wallpers\\8.jpg");
                pictureBox8.Image = Image.FromFile("C:\\Wallpers\\9.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження зображення: " + ex.Message);
            }
        }

        private void InitializeComponents()
        {
            // Створюємо та налаштовуємо PictureBox1, 2, 3, 4, 5

            pictureBox1 = new PictureBox();
            pictureBox1.Size = new Size(80, 50);
            pictureBox1.BackColor = Color.Blue;
            Controls.Add(pictureBox1); // Додаємо PictureBox1 на форму
            pictureBox1.Location = new Point(150, 150); // Розташовуємо PictureBox1 на формі

            pictureBox2 = new PictureBox();
            pictureBox2.Size = new Size(80, 100);
            pictureBox2.BackColor = Color.Red;
            Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(250, 100);

            pictureBox3 = new PictureBox();
            pictureBox3.Size = new Size(80, 80);
            pictureBox3.BackColor = Color.Yellow;
            Controls.Add(pictureBox3);
            pictureBox3.Location = new Point(350, 120);

            pictureBox4 = new PictureBox();
            pictureBox4.Size = new Size(80, 100);
            pictureBox4.BackColor = Color.Blue;
            Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(450, 100);

            pictureBox5 = new PictureBox();
            pictureBox5.Size = new Size(80, 50);
            pictureBox5.BackColor = Color.Red;
            Controls.Add(pictureBox5);
            pictureBox5.Location = new Point(550, 150);

            pictureBox6 = new PictureBox();
            pictureBox6.Size = new Size(130, 100);
            pictureBox6.BackColor = Color.Yellow;
            Controls.Add(pictureBox6);
            pictureBox6.Location = new Point(150, 250);

            pictureBox7 = new PictureBox();
            pictureBox7.Size = new Size(100, 100);
            pictureBox7.BackColor = Color.Blue;
            Controls.Add(pictureBox7);
            pictureBox7.Location = new Point(300, 250);

            pictureBox8 = new PictureBox();
            pictureBox8.Size = new Size(180, 100);
            pictureBox8.BackColor = Color.Red;
            Controls.Add(pictureBox8);
            pictureBox8.Location = new Point(420, 250);
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new Program());
        }
    }
}
