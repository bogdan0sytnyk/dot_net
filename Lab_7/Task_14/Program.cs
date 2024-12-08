using System;
using System.Windows.Forms;

namespace Task_14
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load);
        }

        private void InitializeComponent()
        {
            //throw new NotImplementedException();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Завантажити форму проекту?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                this.Close(); // Закрити форму, якщо користувач вибрав "НІ"
            }
            else if (result == DialogResult.Yes)
            {
                this.MinimizeBox = false; // Вимкнути кнопку згортання
                this.MaximizeBox = false; // Вимкнути кнопку розгортання
            }
        }

static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MainForm mainForm = new MainForm();
                Application.Run(mainForm);
            }
        }

    }
}
