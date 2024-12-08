using System;
using System.Windows.Forms;
using Task_3;

namespace Task_3
{
    public partial class Form2 : Form
    {

        private void InitializeComponent()
        {
            this.side1TextBox = new System.Windows.Forms.TextBox();
            this.side2TextBox = new System.Windows.Forms.TextBox();
            this.hypotenuseLabel = new System.Windows.Forms.Label();
            this.perimeterLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // side1TextBox
            // 
            this.side1TextBox.Location = new System.Drawing.Point(13, 18);
            this.side1TextBox.Name = "side1TextBox";
            this.side1TextBox.Size = new System.Drawing.Size(100, 22);
            this.side1TextBox.TabIndex = 0;
            // 
            // side2TextBox
            // 
            this.side2TextBox.Location = new System.Drawing.Point(13, 46);
            this.side2TextBox.Name = "side2TextBox";
            this.side2TextBox.Size = new System.Drawing.Size(100, 22);
            this.side2TextBox.TabIndex = 1;
            // 
            // hypotenuseLabel
            // 
            this.hypotenuseLabel.AutoSize = true;
            this.hypotenuseLabel.Location = new System.Drawing.Point(13, 75);
            this.hypotenuseLabel.Name = "hypotenuseLabel";
            this.hypotenuseLabel.Size = new System.Drawing.Size(0, 16);
            this.hypotenuseLabel.TabIndex = 2;
            // 
            // perimeterLabel
            // 
            this.perimeterLabel.AutoSize = true;
            this.perimeterLabel.Location = new System.Drawing.Point(13, 97);
            this.perimeterLabel.Name = "perimeterLabel";
            this.perimeterLabel.Size = new System.Drawing.Size(0, 16);
            this.perimeterLabel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Розрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(251, 166);
            this.Controls.Add(this.button1);
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
            if (!double.TryParse(side1TextBox.Text, out double side1) || !double.TryParse(side2TextBox.Text, out double side2))
            {
                MessageBox.Show("Будь ласка, введіть коректні числа.");
                return;
            }

            // Перевірити, чи введені дані відповідають умовам задачі
            if (side1 <= 0 || side2 <= 0)
            {
                MessageBox.Show("Сторони повинні бути додатними числами.");
                return;
            }

            // Обчислити гіпотенузу та периметр
            double hypotenuse = Math.Sqrt(side1 * side1 + side2 * side2);
            double perimeter = side1 + side2 + hypotenuse;

            // Вивести результати
            hypotenuseLabel.Text = $"Гіпотенуза: {hypotenuse:F2}";
            perimeterLabel.Text = $"Периметр: {perimeter:F2}";
        }

        private TextBox side1TextBox;
        private TextBox side2TextBox;
        private Label hypotenuseLabel;
        private Label perimeterLabel;
        private Button button1;
    }
}