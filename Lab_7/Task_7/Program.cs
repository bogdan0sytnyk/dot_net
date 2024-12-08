using System;
using System.Drawing;
using System.Windows.Forms;

public class MainForm : Form
{
    private Label label1, label2, label3;
    private bool isMouseDown = false;

    public MainForm()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        this.Text = "Рядки з ефектом";
        this.Size = new Size(400, 300);
        this.StartPosition = FormStartPosition.CenterScreen;

        label1 = CreateLabel("Рядок 1", 50, 50);
        label2 = CreateLabel("Рядок 2", 50, 100);
        label3 = CreateLabel("Рядок 3", 50, 150);

        label1.MouseDown += OnMouseDown;
        label2.MouseDown += OnMouseDown;
        label3.MouseDown += OnMouseDown;

        label1.MouseUp += OnMouseUp;
        label2.MouseUp += OnMouseUp;
        label3.MouseUp += OnMouseUp;
    }

    private Label CreateLabel(string text, int x, int y)
    {
        Label label = new Label();
        label.Text = text;
        label.AutoSize = true;
        label.Location = new Point(x, y);
        this.Controls.Add(label);
        return label;
    }

    private void OnMouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            Label label = (Label)sender;
            label.BackColor = Color.Blue;
            isMouseDown = true;
        }
    }

    private void OnMouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left && isMouseDown)
        {
            Label label = (Label)sender;
            label.BackColor = Color.Red;
            isMouseDown = false;
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
