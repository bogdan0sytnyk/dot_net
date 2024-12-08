using System;
using System.Drawing;
using System.Windows.Forms;

public class MainForm : Form
{
    private Button button1, button2, button3;

    public MainForm()
    {
        InitializeComponents();
        Size = new Size(200, 300);
    }

    private void InitializeComponents()
    {
        this.Text = "Кнопки з ефектом";
        this.Size = new Size(300, 300);
        this.StartPosition = FormStartPosition.CenterScreen;

        button1 = new Button();
        button1.Text = "Кнопка 1";
        button1.Size = new Size(100, 30);
        button1.Location = new Point(50, 50);
        button1.MouseEnter += OnMouseEnter;
        button1.MouseLeave += OnMouseLeave;

        button2 = new Button();
        button2.Text = "Кнопка 2";
        button2.Size = new Size(100, 30);
        button2.Location = new Point(50, 90);
        button2.MouseEnter += OnMouseEnter;
        button2.MouseLeave += OnMouseLeave;

        button3 = new Button();
        button3.Text = "Кнопка 3";
        button3.Size = new Size(100, 30);
        button3.Location = new Point(50, 130);
        button3.MouseEnter += OnMouseEnter;
        button3.MouseLeave += OnMouseLeave;

        this.Controls.Add(button1);
        this.Controls.Add(button2);
        this.Controls.Add(button3);
    }

    private void OnMouseEnter(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        button.BackColor = Color.Blue;
    }

    private void OnMouseLeave(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        button.BackColor = Color.Red;
    }
}

class Program
{
    static void Main()
    {
        Application.Run(new MainForm());
    }
}
