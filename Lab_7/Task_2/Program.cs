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
            for (int i = 1; i <= 3; i++)
            {
                Button button = new Button();
                button.Text = $"Кнопка {i}";
                button.Click += new EventHandler(Button_Click);
                button.Location = new System.Drawing.Point((this.Width - button.Width) / 2, 50 + (i - 1) * 50);
                this.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            Form newForm = new Form();
            newForm.Text = $"Вікно {clickedButton.Text}";
            newForm.Size = new System.Drawing.Size(3, 3);
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = new System.Drawing.Point(this.Right - newForm.Width - 10, this.Bottom - newForm.Height - 10);

            Label label = new Label();
            label.Text = "Текст";
            label.Location = new System.Drawing.Point(3, 3);
            newForm.Controls.Add(label);

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
