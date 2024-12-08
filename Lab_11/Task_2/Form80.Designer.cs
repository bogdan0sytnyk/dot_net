using System;
using System.Drawing;
using System.Windows.Forms;
using Task_2;

namespace Task_2
{
    public partial class Form80 : Form
    {
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Form80
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "Form80";
            this.Text = "Form80";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public string Information
        {
            get { return textBox1.Text; }
        }
    }
}