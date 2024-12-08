using System;
using System.Drawing;
using System.Windows.Forms;
using Task_10;

namespace Task_10
{
    public partial class MainForm : Form
    {
        private Button button1;
        private Timer timer = new Timer();
        private TextBox intervalTextBox = new TextBox();
        private Button startButton = new Button();
        private Button stopButton = new Button();

        public MainForm()
        {
            InitializeComponent();

            // Налаштування таймера
            timer.Interval = 500; // Початковий інтервал - 0.5 секунди
            timer.Tick += TimerTick;
            timer.Start(); // Початок роботи таймера
        }

        private void InitializeComponent()
        {
            // Створення компонентів
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Налаштування кнопки button1
            this.button1.Location = new System.Drawing.Point(106, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // Налаштування форми MainForm
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button1);

            // Налаштування текстового поля для інтервалу
            this.intervalTextBox.Location = new Point(10, 100);
            this.intervalTextBox.Text = "500";
            this.Controls.Add(intervalTextBox);

            // Налаштування кнопки "Старт"
            this.startButton.Location = new Point(10, 130);
            this.startButton.Text = "Старт";
            this.startButton.Click += StartButtonClick;
            this.Controls.Add(startButton);

            // Налаштування кнопки "Стоп"
            this.stopButton.Location = new Point(100, 130);
            this.stopButton.Text = "Стоп";
            this.stopButton.Click += StopButtonClick;
            this.Controls.Add(stopButton);

            this.ResumeLayout(false);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            // Перемикаємо кольори тексту кнопки
            button1.ForeColor = (button1.ForeColor == Color.Red) ? Color.Blue : Color.Red;
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            int interval;
            if (int.TryParse(intervalTextBox.Text, out interval))
            {
                timer.Interval = interval;
                timer.Start();
            }
        }

        private void StopButtonClick(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ваш код обробки події Click кнопки button1
        }
    }
}

class Program
{
    static void Main()
    {
        Application.Run(new MainForm());
    }
}
