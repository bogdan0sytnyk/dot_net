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

        EventHandler onEnterLeave = (sender, e) =>
        {
            TextBox textBox = (TextBox)sender;

            if (e is KeyEventArgs keyEvent && keyEvent.KeyCode == Keys.Enter)
            {
                textBox.BackColor = Color.Red;
                textBox.SelectAll(); // Виділити весь текст
            }
            else if (e is EventArgs)
            {
                textBox.BackColor = DefaultBackColor;
            }
        };

        textBox1.Enter += onEnterLeave;
        textBox2.Enter += onEnterLeave;
        textBox3.Enter += onEnterLeave;

        textBox1.Leave += onEnterLeave;
        textBox2.Leave += onEnterLeave;
        textBox3.Leave += onEnterLeave;

        textBox1.KeyDown += new KeyEventHandler(onEnterLeave);
        textBox2.KeyDown += new KeyEventHandler(onEnterLeave);
        textBox3.KeyDown += new KeyEventHandler(onEnterLeave);
    }

    private TextBox CreateTextBox(int x, int y)
    {
        TextBox textBox = new TextBox();
        textBox.Size = new Size(200, 20);
        textBox.Location = new Point(x, y);
        this.Controls.Add(textBox);
        return textBox;
    }
}

class Program
{
    static void Main()
    {
        Application.Run(new MainForm());
    }
}
