using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeComponent()
        {
            //throw new NotImplementedException();
        }

        private void InitializeButtons()
        {
            Button button1 = new Button();
            button1.Text = "Кнопка 1";
            button1.Click += new EventHandler(Button_Click);
            button1.Location = new System.Drawing.Point((this.Width - button1.Width) / 2, 50);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Text = "Кнопка 2";
            button2.Click += new EventHandler(Button_Click);
            button2.Location = new System.Drawing.Point((this.Width - button2.Width) / 2, 100);
            this.Controls.Add(button2);

            Button button3 = new Button();
            button3.Text = "Кнопка 3";
            button3.Click += new EventHandler(Button_Click);
            button3.Location = new System.Drawing.Point((this.Width - button3.Width) / 2, 150);
            this.Controls.Add(button3);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            Form newForm = new Form();
            newForm.Text = $"Вікно {clickedButton.Text}";
            newForm.Size = new System.Drawing.Size(3, 3); // Встановлення розміру: ширина - 200, висота - 100
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = new System.Drawing.Point(this.Right - newForm.Width - 8, this.Bottom - newForm.Height - 8);

            // Додаємо мітку
            Label label = new Label();
            label.Text = "Текст";
            label.Location = new System.Drawing.Point(3, 3);
            newForm.Controls.Add(label);

            // Приховуємо рамку вікна
            newForm.FormBorderStyle = FormBorderStyle.None;

            newForm.Show();
        }
    }

        static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}