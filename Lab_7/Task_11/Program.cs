using System;
using System.Windows.Forms;

public class MainForm : Form
{
    private TextBox textBox;

    public MainForm()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        this.Text = "Обмеження символів";
        this.Size = new System.Drawing.Size(300, 200);
        this.StartPosition = FormStartPosition.CenterScreen;

        textBox = new TextBox();
        textBox.Size = new System.Drawing.Size(200, 20);
        textBox.Location = new System.Drawing.Point(50, 80);

        // Додаємо обробник події KeyPress
        textBox.KeyPress += OnKeyPress;

        this.Controls.Add(textBox);
    }

    private void OnKeyPress(object sender, KeyPressEventArgs e)
    {
        // Перевіряємо чи введений символ належить діапазону від 'A' до 'M' (верхній регістр)
        if (!(e.KeyChar >= 'A' && e.KeyChar <= 'M') && !(e.KeyChar >= 'a' && e.KeyChar <= 'm'))
        {
            // Якщо символ не належить діапазону, відміняємо введення
            e.Handled = true;
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
