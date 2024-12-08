using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_5
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
            AddTextToPictureBoxes(); // Додаємо текст до PictureBoxes
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

        private void AddTextToPictureBoxes()
        {
            // Додаємо текст до pictureBox1
            using (Graphics g = Graphics.FromImage(new Bitmap(pictureBox1.Width, pictureBox1.Height)))
            {
                g.DrawString("Текст для pictureBox1", new Font("Arial", 12), Brushes.Black, new Point(10, 10));
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                g.DrawImage(pictureBox1.Image, Point.Empty);
            }

            // Додаємо текст до pictureBox2
            using (Graphics g = Graphics.FromImage(new Bitmap(pictureBox2.Width, pictureBox2.Height)))
            {
                g.DrawString("Текст для pictureBox2", new Font("Arial", 12), Brushes.Black, new Point(10, 10));
                pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                g.DrawImage(pictureBox2.Image, Point.Empty);
            }

            // Додаємо текст до pictureBox3
            using (Graphics g = Graphics.FromImage(new Bitmap(pictureBox3.Width, pictureBox3.Height)))
            {
                g.DrawString("Текст для pictureBox3", new Font("Arial", 12), Brushes.Black, new Point(10, 10));
                pictureBox3.Image = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                g.DrawImage(pictureBox3.Image, Point.Empty);
            }
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new Program());
        }
    }
}