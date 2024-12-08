using System;
using System.Windows.Forms;
using System.Drawing;

namespace Task_2
{
    public class MainForm : Form
    {
        public MainForm()
        {
            // Створення та конфігурація компонентів Label

            Label label1 = new Label();
            label1.Text = "Таск2";
            label1.Font = new Font("Arial", 20, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
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

            // Створення та конфігурація компоненту TextBox
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Text = "Це текст, який був доданий програмно.";
            textBox.Font = new Font("Arial", 12);
            textBox.ForeColor = Color.Blue;
            textBox.BackColor = Color.LightYellow;
            textBox.Size = new Size(200, 100);
            textBox.Location = new Point(50, 200);

            // Додавання TextBox на форму
            this.Controls.Add(textBox);

            // Налаштування розміру форми
            this.ClientSize = new Size(300, 350);

            // Налаштування заголовка форми
            this.Text = "Task_2";

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