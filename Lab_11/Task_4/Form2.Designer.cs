using System;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.TextBox side1TextBox;
        private System.Windows.Forms.TextBox side2TextBox;
        private System.Windows.Forms.Label hypotenuseLabel;
        private System.Windows.Forms.Label perimeterLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox side3TextBox;

        private void InitializeComponent()
        {
            this.side1TextBox = new System.Windows.Forms.TextBox();
            this.side2TextBox = new System.Windows.Forms.TextBox();
            this.hypotenuseLabel = new System.Windows.Forms.Label();
            this.perimeterLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.side3TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // side1TextBox
            this.side1TextBox.Location = new System.Drawing.Point(13, 18);
            this.side1TextBox.Name = "side1TextBox";
            this.side1TextBox.Size = new System.Drawing.Size(100, 22);
            this.side1TextBox.TabIndex = 0;

            // side2TextBox
            this.side2TextBox.Location = new System.Drawing.Point(13, 46);
            this.side2TextBox.Name = "side2TextBox";
            this.side2TextBox.Size = new System.Drawing.Size(100, 22);
            this.side2TextBox.TabIndex = 1;

            // hypotenuseLabel
            this.hypotenuseLabel.AutoSize = true;
            this.hypotenuseLabel.Location = new System.Drawing.Point(13, 105);
            this.hypotenuseLabel.Name = "hypotenuseLabel";
            this.hypotenuseLabel.Size = new System.Drawing.Size(0, 16);
            this.hypotenuseLabel.TabIndex = 2;

            // perimeterLabel
            this.perimeterLabel.AutoSize = true;
            this.perimeterLabel.Location = new System.Drawing.Point(13, 97);
            this.perimeterLabel.Name = "perimeterLabel";
            this.perimeterLabel.Size = new System.Drawing.Size(0, 16);
            this.perimeterLabel.TabIndex = 3;

            // calculateButton
            this.calculateButton.Location = new System.Drawing.Point(13, 129);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(110, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Розрахувати";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);

            // side3TextBox
            this.side3TextBox.Location = new System.Drawing.Point(13, 75);
            this.side3TextBox.Name = "side3TextBox";
            this.side3TextBox.Size = new System.Drawing.Size(100, 22);
            this.side3TextBox.TabIndex = 5;

            // Form1
            this.ClientSize = new System.Drawing.Size(251, 166);
            this.Controls.Add(this.side3TextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.perimeterLabel);
            this.Controls.Add(this.hypotenuseLabel);
            this.Controls.Add(this.side2TextBox);
            this.Controls.Add(this.side1TextBox);
            this.Name = "Form1";
            this.Text = "1 варіант";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Отримати введені дані
            if (!double.TryParse(side1TextBox.Text, out double side1) ||
                !double.TryParse(side2TextBox.Text, out double side2) ||
                !double.TryParse(side3TextBox.Text, out double side3))
            {
                MessageBox.Show("Будь ласка, введіть коректні числа.");
                return;
            }
            // Перевірити, чи введені дані відповідають умовам задачі
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                MessageBox.Show("Сторони повинні бути додатніми числами.");
                return;
            }

            // Використання значень у вашій формулі
            double result = Math.Pow(side1 * side2, Math.Cos(side2) * Math.Sin(side1)) / (Math.Pow(side1, 1) + side2 - side3);

            // Відображення результату
            hypotenuseLabel.Text = $"Відповідь по формулі: {result:F2}";
        }
    }
}