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
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();

            label1.Text = "Рядок 1";
            label2.Text = "Рядок 2";
            label3.Text = "Рядок 3";

            label1.Location = new Point(50, 50);
            label2.Location = new Point(50, 100);
            label3.Location = new Point(50, 150);

            label1.DoubleClick += new EventHandler(LabelDoubleClick);
            label2.DoubleClick += new EventHandler(LabelDoubleClick);
            label3.DoubleClick += new EventHandler(LabelDoubleClick);

            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
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
