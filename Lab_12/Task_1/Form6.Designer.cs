using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Task_1
{
    partial class Form6
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get a Message";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open Message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(85, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 307);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Khpgram";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            // Створюємо градієнтний кисть
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                groupBox1.ClientRectangle,
                Color.White, // Верхній колір (білий)
                Color.Green, // Нижній колір (зелений)
                LinearGradientMode.Vertical); // Вказуємо вертикальний градієнт

            // Використовуючи кисть, заповнюємо прямокутник градієнтом
            e.Graphics.FillRectangle(gradientBrush, groupBox1.ClientRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault();
            if (form5 != null)
            {
                List<string> files = form5.GetAttachmentPaths();
                ReceiveFiles(files);
                MessageBox.Show("Файлы успешно сохранены.");
            }
            else
            {
                MessageBox.Show("Форма 5 не найдена.");
            }
        }

        public void ReceiveFiles(List<string> files)
        {
            foreach (string filePath in files)
            {
                try
                {
                    string fileName = Path.GetFileName(filePath);
                    string destinationPath = Path.Combine(@"C:\SavedFiles", fileName);
                    File.Copy(filePath, destinationPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
                }
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault();
            List<string> attachments = form5.GetAttachmentPaths();

            if (form5 != null)
            {
                string messageText = form5.GetTextBox1Text();
                MessageBox.Show(messageText, "Перегляд повідомлення");
            }
            else
            {
                MessageBox.Show("Немає форми для перегляду", "Увага");
            }

            if (form5 != null)
            {
                string messageText = form5.GetTextBox2Text();
                MessageBox.Show(messageText, "Перегляд повідомлення");
            }
            else
            {
                MessageBox.Show("Немає форми для перегляду", "Увага");
            }

            if (attachments.Count > 0)
            {
                string attachmentNames = string.Join("\n", attachments.Select(Path.GetFileName));
                MessageBox.Show("Вкладені файли:\n" + attachmentNames, "Перегляд вкладень");
            }
            else
            {
                MessageBox.Show("Немає вкладених файлів", "Увага");
            }
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Button button2;
        private Button button3;
    }
}