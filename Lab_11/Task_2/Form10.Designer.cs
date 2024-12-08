using System;
using System.Drawing;
using System.Windows.Forms;
using Task_2;

namespace Task_2
{
    public partial class Form10 : Form
    {
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Інформація з Form20, Form30 та Form40:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Form10
            // 
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.ShowDialog();
            // Після закриття Form20, візьмемо інформацію з неї та відобразимо на Form10
            label1.Text = "Інформація з Form20:";
            textBox1.Text = form20.Information; // Information - властивість у Form20, де зберігається інформація
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form30 form30 = new Form30();
            form30.ShowDialog();
            label1.Text = "Інформація з Form30:";
            textBox1.Text = form30.Information; // Information - властивість у Form20, де зберігається інформація
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form40 form40 = new Form40();
            form40.ShowDialog();
            label1.Text = "Інформація з Form40:";
            textBox1.Text = form40.Information; // Information - властивість у Form20, де зберігається інформація
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form40 form40 = new Form40();
            form40.ShowDialog();
        }
    }
}

