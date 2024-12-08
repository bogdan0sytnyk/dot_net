using System;
using System.Windows.Forms;
using System.Drawing;

namespace Task_1
{
    public class MainForm : Form
    {
        public MainForm()
        {
            // Створення та конфігурація компонентів Label

            Label label1 = new Label();
            label1.Text = "Таск1";
            label1.Font = new Font("Arial", 20, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label1.Size = new Size(100, 50);
            label1.BackColor = Color.Red;
            label1.ForeColor = Color.Green;

            Label label2 = new Label();
            label2.Text = "Текст";
            label2.Font = new Font("Arial", 13, FontStyle.Underline);
            label2.ForeColor = Color.Gray;
            label2.TextAlign = ContentAlignment.MiddleRight;

            Label label3 = new Label();
            label3.Text = "Текст";
            label3.Font = new Font("Arial", 14, FontStyle.Bold);
            label3.ForeColor = Color.Pink;
            label3.TextAlign = ContentAlignment.MiddleRight;

            // Розміщення компонентів на формі

            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);

            label1.Location = new Point(50, 50);
            label2.Location = new Point(50, 100);
            label3.Location = new Point(50, 150);

            // Налаштування розміру форми
            this.ClientSize = new Size(300, 250);

            // Налаштування заголовка форми
            this.Text = "Task_1";

            // Відображення форми
            this.Show();
        }
    }

    // Головний метод для запуску програми
    public class Program
    {
        public static void Main()
        {
            Application.Run(new MainForm());
        }
    }
}