using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoubleClickExample
{
    public class Program
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1();
            Application.Run(form);
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeLabels();
        }

        private void InitializeComponent()
        {
            //throw new NotImplementedException();
        }

        private void InitializeLabels()
        {
            for (int i = 0; i < 3; i++)
            {
                Label label = new Label();
                label.Text = $"Рядок {i + 1}";
                label.Location = new Point(50, 50 + i * 50);
                label.DoubleClick += new EventHandler(LabelDoubleClick);
                this.Controls.Add(label);
            }
        }

        private void LabelDoubleClick(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            ToggleFormColor();
            clickedLabel.Text = "Подвійний клік!";
        }

        private void ToggleFormColor()
        {
            if (this.BackColor == Color.Blue)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Blue;
            }
        }
    }
}
