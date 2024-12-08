using System;
using System.Drawing.Printing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Task_9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            comboBox1 = new System.Windows.Forms.ComboBox(); // Заменили радиокнопки на ComboBox
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();

            // groupBox1
            groupBox1.Controls.Add(comboBox1); // Добавили ComboBox вместо радиокнопок
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Опт телефонів";

            // comboBox1
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; // Настроили ComboBox как выпадающий список
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "від 5", "від 10", "від 15" });
            comboBox1.Location = new System.Drawing.Point(9, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 28);
            comboBox1.TabIndex = 0;

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
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "ОК";
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
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double price = 0;

            if (comboBox1.SelectedIndex == 0)
                price = 68000;
            else if (comboBox1.SelectedIndex == 1)
                price = 135000;
            else if (comboBox1.SelectedIndex == 2)
                price = 195000;
            int quantity = Convert.ToInt32(textBox1.Text);
            double total = price * quantity;
            label2.Text = "Сума: " + total;
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

