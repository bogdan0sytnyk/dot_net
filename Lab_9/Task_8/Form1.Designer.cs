using System;

namespace Task_9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBox1 = new System.Windows.Forms.GroupBox();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton3 = new System.Windows.Forms.RadioButton();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();

            // groupBox1
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Опт телефонів";

            // radioButton1
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(9, 29);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(117, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "від 5";
            radioButton1.UseVisualStyleBackColor = true;

            // radioButton2
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(9, 59);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(117, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "від 10";
            radioButton2.UseVisualStyleBackColor = true;

            // radioButton3
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(9, 89);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(117, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "від 15";
            radioButton3.UseVisualStyleBackColor = true;

            // textBox1
            textBox1.Location = new System.Drawing.Point(90, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(125, 27);
            textBox1.TabIndex = 1;

            // label1
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 179);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Кількість:";

            // button1
            button1.Location = new System.Drawing.Point(12, 223);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 35);
            button1.TabIndex = 3;
            button1.Text = "ОК (опт)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.Button1_Click);

            // label2
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 277);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "";
            // Form1
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(428, 307);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "SAMSUNG";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
            // button2
            button2 = new System.Windows.Forms.Button();
            button2.Location = new System.Drawing.Point(102, 167);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 26);
            button2.TabIndex = 4;
            button2.Text = "ОК (роздріб)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.Button2_Click);
            Controls.Add(button2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double price = 0;

            if (radioButton1.Checked)
                price = 68000;
            else if (radioButton2.Checked)
                price = 135000;
            else if (radioButton3.Checked)
                price = 195000;

            int quantity = Convert.ToInt32(textBox1.Text);
            double total = price * quantity;
            label2.Text = "Оптова сума: " + total;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double price = 0;

            if (radioButton1.Checked)
                price = 69000;
            else if (radioButton2.Checked)
                price = 138000;
            else if (radioButton3.Checked)
                price = 207000;

            int quantity = Convert.ToInt32(textBox1.Text);
            double total = price * quantity;
            label2.Text = "Роздрібна сума: " + total;
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}
