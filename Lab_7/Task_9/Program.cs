using System;
using System.Drawing;
using System.Windows.Forms;

public class MainForm : Form
{
    private TextBox textBox1, textBox2, textBox3;

    public MainForm()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        this.Text = "Текстові поля з ефектом";
        this.Size = new Size(400, 300);
        this.StartPosition = FormStartPosition.CenterScreen;

        textBox1 = CreateTextBox(50, 50);
        textBox2 = CreateTextBox(50, 100);
        textBox3 = CreateTextBox(50, 150);

        textBox1.Enter += OnEnter;
        textBox2.Enter += OnEnter;
        textBox3.Enter += OnEnter;

        textBox1.Leave += OnLeave;
        textBox2.Leave += OnLeave;
        textBox3.Leave += OnLeave;

        textBox1.KeyDown += OnKeyDown;
        textBox2.KeyDown += OnKeyDown;
        textBox3.KeyDown += OnKeyDown;
    }

    private TextBox CreateTextBox(int x, int y)
    {
        TextBox textBox = new TextBox();
        textBox.Size = new Size(200, 20);
        textBox.Location = new Point(x, y);
        this.Controls.Add(textBox);
        return textBox;
    }

    private void OnEnter(object sender, EventArgs e)
    {
        TextBox textBox = (TextBox)sender;
        textBox.BackColor = Color.Blue;
    }

    private void OnLeave(object sender, EventArgs e)
    {
        TextBox textBox = (TextBox)sender;
        textBox.BackColor = Color.White;
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.Red;
            textBox.SelectAll(); // Виділити весь текст
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
