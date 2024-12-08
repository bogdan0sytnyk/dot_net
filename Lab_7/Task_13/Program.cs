using System;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class MainForm : Form
    {
        private PictureBox pictureBox;

        public MainForm()
        {
            InitializeComponent();
            InitializePictureBox();
        }

        private void InitializeComponent()
        {
            //throw new NotImplementedException();
        }

        private void InitializePictureBox()
        {
            pictureBox = new PictureBox();
            pictureBox.Size = new System.Drawing.Size(100, 100);
            pictureBox.Location = new System.Drawing.Point(50, 50);
            pictureBox.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(pictureBox);
            pictureBox.Visible = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.A))
            {
                // Додаємо PictureBox на форму
                pictureBox.Visible = true;
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D))
            {
                // Видаляємо PictureBox з форми
                pictureBox.Visible = false;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
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
