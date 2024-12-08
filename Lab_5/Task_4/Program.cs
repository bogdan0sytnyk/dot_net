using System;
using System.Windows.Forms;
using System.Drawing;

namespace Task_4
{
    public class MainForm : Form
    {
        public MainForm()
        {
            // Створення та конфігурація компонентів TextBox

            TextBox textBox1 = new TextBox();
            textBox1.Text = "Таск4";
            textBox1.Font = new Font("Arial", 20, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            textBox1.ForeColor = Color.Green;
            textBox1.ReadOnly = true;

            TextBox textBox2 = new TextBox();
            textBox2.Text = "Текст";
            textBox2.Font = new Font("Arial", 13, FontStyle.Underline);
            textBox2.ForeColor = Color.Gray;
            textBox2.TextAlign = HorizontalAlignment.Right;

            TextBox textBox3 = new TextBox();
            textBox3.Text = "Текст";
            textBox3.Font = new Font("Arial", 14, FontStyle.Bold);
            textBox3.ForeColor = Color.Pink;
            textBox3.TextAlign = HorizontalAlignment.Right;

            // Розміщення компонентів на формі

            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);

            textBox1.Location = new Point(50, 50);
            textBox2.Location = new Point(50, 100);
            textBox3.Location = new Point(50, 150);

            // Створення та конфігурація компоненту TextBox
            TextBox textBox4 = new TextBox();
            textBox4.Multiline = true;
            textBox4.Text = "Це текст, який був доданий програмно.";
            textBox4.Font = new Font("Arial", 12);
            textBox4.ForeColor = Color.Blue;
            textBox4.BackColor = Color.LightYellow;
            textBox4.Size = new Size(200, 100);
            textBox4.Location = new Point(50, 200);

            // Додавання TextBox на форму
            this.Controls.Add(textBox4);

            // Додання додаткових текстових полів
            TextBox textBox5 = new TextBox();
            textBox5.Text = "Текст 1";
            textBox5.Font = new Font("Arial", 12);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(50, 320);
            this.Controls.Add(textBox5);

            TextBox textBox6 = new TextBox();
            textBox6.Text = "Текст 2";
            textBox6.Font = new Font("Arial", 12);
            textBox6.ForeColor = Color.Black;
            textBox6.Location = new Point(50, 350);
            this.Controls.Add(textBox6);

            // Налаштування розміру форми
            this.ClientSize = new Size(300, 450);

            // Налаштування заголовка форми
            this.Text = "Task_4";

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