using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private double selectedAccessoriesPrice = 0; // Додав нову змінну

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 16);
            this.label1.TabIndex = 0;
            this.label1.Font = new Font(label1.Font, FontStyle.Bold); // Устанавливаем жирный шрифт
            this.label1.ForeColor = Color.Blue; // Устанавливаем цвет текста
            this.label1.Text = "Xiaomi Poco X3 Pro 6/128GB Phantom Black";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 69);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Захисне скло";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(25, 95);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 20);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Чохол";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(25, 121);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(186, 20);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Картка доп пам\'яті 64GB";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(25, 147);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(102, 20);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Повербанк";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ціна телефону: 13 900";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ціна телефону в комплекті:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ціна на інше:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Знижка:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Разом:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(294, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            // Додаємо обробники подій для чекбоксів
            checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox_CheckedChanged;
            checkBox4.CheckedChanged += CheckBox_CheckedChanged;

            // Додаємо обробник події для кнопки
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double phonePrice = 13900; // Ціна телефону

            double selectedAccessoriesPrice = 0; // Ціна вибраних аксесуарів
            if (checkBox1.Checked)
                selectedAccessoriesPrice += 200; // Приклад: Ціна захисного скла

            if (checkBox2.Checked)
                selectedAccessoriesPrice += 200; // Приклад: Ціна чохла

            if (checkBox3.Checked)
                selectedAccessoriesPrice += 500; // Приклад: Ціна картки пам'яті

            if (checkBox4.Checked)
                selectedAccessoriesPrice += 500; // Приклад: Ціна повербанку

            double total = phonePrice + selectedAccessoriesPrice;
            double all = phonePrice + selectedAccessoriesPrice;
            double discount = 0;

            // Перевірка, чи вибрано всі чекбокси
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                discount = total * 0.05; // Знижка 5% за всі аксесуари
            }

            double finalPrice = total - discount;

            label3.Text = "Ціна телефону в комплекті: " + all;
            label4.Text = "Ціна на інше: " + selectedAccessoriesPrice;
            label5.Text = "Знижка: " + discount;
            label6.Text = "Разом: " + finalPrice;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
            {
                switch (checkBox.Name)
                {
                    case "checkBox1":
                        selectedAccessoriesPrice += 200; // Ціна захисного скла
                        break;
                    case "checkBox2":
                        selectedAccessoriesPrice += 200; // Ціна чохла
                        break;
                    case "checkBox3":
                        selectedAccessoriesPrice += 500; // Ціна карти пам'яті
                        break;
                    case "checkBox4":
                        selectedAccessoriesPrice += 500; // Ціна повербанку
                        break;
                }
            }
            else
            {
                switch (checkBox.Name)
                {
                    case "checkBox1":
                        selectedAccessoriesPrice -= 200; // Ціна захисного скла
                        break;
                    case "checkBox2":
                        selectedAccessoriesPrice -= 200; // Ціна чохла
                        break;
                    case "checkBox3":
                        selectedAccessoriesPrice -= 500; // Ціна карти пам'яті
                        break;
                    case "checkBox4":
                        selectedAccessoriesPrice -= 500; // Ціна повербанку
                        break;
                }
            }
        }
    }
}

