using System.Windows.Forms;
using System;
using Task_3;

namespace Task_3
{
    partial class Form4_2
    {
        private System.Windows.Forms.Button button1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Розпочати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form4_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 107);
            this.Controls.Add(this.button1);
            this.Name = "Form4_2";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Form4_1 inputForm = new Form4_1();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                double side1 = inputForm.Side1;
                double side2 = inputForm.Side2;

                double hypotenuse = Math.Sqrt(side1 * side1 + side2 * side2);
                double perimeter = side1 + side2 + hypotenuse;

                Form4_3 resultForm = new Form4_3(hypotenuse, perimeter);
                resultForm.ShowDialog();
            }
        }


     #endregion
    }
}