using System;
using System.Drawing;
using System.Windows.Forms;
using Task_1;

namespace Task_1
{
    public partial class Form70 : Form
    {


        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form70
            // 
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form70";
            this.Text = "Form70";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form90 form90 = new Form90();
            form90.ShowDialog();
        }

        private Button button1;
    }
}