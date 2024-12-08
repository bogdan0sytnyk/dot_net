using System;
using System.Drawing;
using System.Windows.Forms;
using Task_1;

namespace Task_1
{
    public partial class Form80 : Form
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
            // 
            // Form10
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "Form80";
            this.Text = "Form80";
            this.ResumeLayout(false);

        }

        private Button button1;
    }
}