using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private int seconds = 0;
        private Timer timer;

        private NumericUpDown numericUpDownMinutes;
        private NumericUpDown numericUpDownSeconds;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "00";
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Location = new System.Drawing.Point(20, 61);
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(45, 22);
            this.numericUpDownMinutes.TabIndex = 5;
            this.numericUpDownMinutes.ValueChanged += new System.EventHandler(this.numericUpDownMinutes_ValueChanged);
            // 
            // numericUpDownSeconds
            // 
            this.numericUpDownSeconds.Location = new System.Drawing.Point(70, 61);
            this.numericUpDownSeconds.Name = "numericUpDownSeconds";
            this.numericUpDownSeconds.Size = new System.Drawing.Size(45, 22);
            this.numericUpDownSeconds.TabIndex = 6;
            this.numericUpDownSeconds.ValueChanged += new System.EventHandler(this.numericUpDownSeconds_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 111);
            this.Controls.Add(this.numericUpDownSeconds);
            this.Controls.Add(this.numericUpDownMinutes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "С";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            timer = new Timer();
            timer.Interval = 1000; // Таймер викликається кожну секунду
            timer.Tick += Timer_Tick;
        }

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;
            label1.Text = minutes.ToString().PadLeft(2, '0');
            label3.Text = remainingSeconds.ToString().PadLeft(2, '0');

            // Зміна кольору фону табло кожні 5 секунд
            if (seconds % 5 == 0)
            {
                Random random = new Random();
                label1.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                label3.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            }
        }

        private void numericUpDownMinutes_ValueChanged(object sender, EventArgs e)
        {
            seconds = (int)numericUpDownMinutes.Value * 60 + (int)numericUpDownSeconds.Value;
            label1.Text = numericUpDownMinutes.Value.ToString().PadLeft(2, '0');
        }

        private void numericUpDownSeconds_ValueChanged(object sender, EventArgs e)
        {
            seconds = (int)numericUpDownMinutes.Value * 60 + (int)numericUpDownSeconds.Value;
            label3.Text = numericUpDownSeconds.Value.ToString().PadLeft(2, '0');
        }
    }
}