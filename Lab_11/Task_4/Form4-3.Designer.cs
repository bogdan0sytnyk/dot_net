using System;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form4_3 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;

        public Form4_3(double hypotenuse)
        {
            InitializeComponent();

            label1.Text = $"Відповідь по формулі: {hypotenuse:F2}";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            // 
            // Form4_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 113);
            this.Controls.Add(this.label1);
            this.Name = "Form4_3";
            this.Text = "Результат";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}