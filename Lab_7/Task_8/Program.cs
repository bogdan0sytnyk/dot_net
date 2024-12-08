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

        MouseEventHandler onMouseDownUp = (sender, e) =>
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = (Label)sender;
                if (isMouseDown)
                {
                    label.BackColor = Color.Red;
                }
                else
                {
                    label.BackColor = Color.Blue;
                }
                isMouseDown = !isMouseDown;
            }
        };

        label1.MouseDown += onMouseDownUp;
        label2.MouseDown += onMouseDownUp;
        label3.MouseDown += onMouseDownUp;

        label1.MouseUp += onMouseDownUp;
        label2.MouseUp += onMouseDownUp;
        label3.MouseUp += onMouseDownUp;
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
}

class Program
{
    static void Main()
    {
        Application.Run(new MainForm());
    }
}
