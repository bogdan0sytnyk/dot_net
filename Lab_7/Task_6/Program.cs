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
        this.Size = new Size(300, 200);
        this.StartPosition = FormStartPosition.CenterScreen;

        button1 = CreateButton("Кнопка 1", 50, 50);
        button2 = CreateButton("Кнопка 2", 50, 90);
        button3 = CreateButton("Кнопка 3", 50, 130);

        EventHandler onMouseEnterLeave = (sender, e) =>
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.Red)
                button.BackColor = Color.Blue;
            else
                button.BackColor = Color.Red;
        };

        button1.MouseEnter += onMouseEnterLeave;
        button2.MouseEnter += onMouseEnterLeave;
        button3.MouseEnter += onMouseEnterLeave;

        button1.MouseLeave += onMouseEnterLeave;
        button2.MouseLeave += onMouseEnterLeave;
        button3.MouseLeave += onMouseEnterLeave;
    }

    private Button CreateButton(string text, int x, int y)
    {
        Button button = new Button();
        button.Text = text;
        button.Size = new Size(100, 30);
        button.Location = new Point(x, y);
        this.Controls.Add(button);
        return button;
    }
}

class Program
{
    static void Main()
    {
        Application.Run(new MainForm());
    }
}
