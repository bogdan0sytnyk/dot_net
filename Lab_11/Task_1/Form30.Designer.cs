using System;
using System.Drawing;
using System.Windows.Forms;
using Task_1;

namespace Task_1
{
    public partial class Form30 : Form
    {


        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form30
            // 
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form30";
            this.Text = "Form30";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form50 form50 = new Form50();
            form50.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form60 form60 = new Form60();
            form60.ShowDialog();
        }

        private Button button1;
        private Button button2;
    }
}