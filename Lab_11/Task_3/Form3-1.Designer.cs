using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form3_1 : Form
    {

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обчислити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form3_1
            // 
            this.ClientSize = new System.Drawing.Size(282, 114);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3_1";
            this.Text = "Введіть дані";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //
        }

        public double Side1 { get; private set; }
        public double Side2 { get; private set; }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double side1) || !double.TryParse(textBox2.Text, out double side2))
            {
                MessageBox.Show("Будь ласка, введіть коректні числа.");
                return;
            }

            if (side1 <= 0 || side2 <= 0)
            {
                MessageBox.Show("Сторони повинні бути додатними числами.");
                return;
            }

            Side1 = side1;
            Side2 = side2;;

            DialogResult = DialogResult.OK;
        }

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}