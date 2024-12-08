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
    public partial class Form3_2 : Form
    {

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Розрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form3_2
            // 
            this.ClientSize = new System.Drawing.Size(282, 130);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3_2";
            this.Text = "Рішення";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Form3_1 inputForm = new Form3_1();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                double side1 = inputForm.Side1;
                double side2 = inputForm.Side2;

                double hypotenuse = Math.Sqrt(side1 * side1 + side2 * side2);
                double perimeter = side1 + side2 + hypotenuse;

                label1.Text = $"Гіпотенуза: {hypotenuse:F2}";
                label2.Text = $"Периметр: {perimeter:F2}";
            }
        }

        private Label label1;
        private Label label2;
        private Button button1;
    }
}