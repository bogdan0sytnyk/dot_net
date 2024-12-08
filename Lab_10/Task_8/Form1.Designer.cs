using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task_9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItemHide;
        private ToolStripMenuItem toolStripMenuItemShow;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            textBox1 = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 346);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 4;
            label2.SizeChanged += CloseToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            statusStrip1.Location = new Point(0, 228);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(625, 32);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(41, 25);
            toolStripStatusLabel1.Text = "0  | ";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 25);
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(179, 25);
            toolStripStatusLabel3.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 49);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 31);
            textBox1.TabIndex = 6;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip2;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, closeToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(129, 68);
            contextMenuStrip2.Text = "Open";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 32);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click_1;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(128, 32);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 260);
            Controls.Add(textBox1);
            Controls.Add(statusStrip1);
            Controls.Add(label2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "StatusStrip";
            Resize += Form1_Resize;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int currentMinutes = DateTime.Now.Minute;
                toolStripStatusLabel1.Text = "" + currentMinutes.ToString() + "  | ";
                toolStripStatusLabel2.Text = " " + textBox1.Text; // Оновити зміст toolStripStatusLabel2 з textBox1
                textBox1.Clear();
            }
        }

        private void InitializeContextMenu()
        {
            contextMenuStrip1 = new ContextMenuStrip(components);

            if (this.Name.EndsWith("1") || this.Name.EndsWith("3") || this.Name.EndsWith("5") || this.Name.EndsWith("7") || this.Name.EndsWith("9"))
            {
                toolStripMenuItemHide = new ToolStripMenuItem("Приховати", null, new EventHandler(HideForm));
                contextMenuStrip1.Items.Add(toolStripMenuItemHide);
            }

            if (this.Name.EndsWith("2") || this.Name.EndsWith("4") || this.Name.EndsWith("6") || this.Name.EndsWith("8") || this.Name.EndsWith("0"))
            {
                toolStripMenuItemShow = new ToolStripMenuItem("Показати", null, new EventHandler(ShowForm));
                contextMenuStrip1.Items.Add(toolStripMenuItemShow);
            }

        }

        private Form1 form1 = null;


        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрыть приложение
        }

        private void MinimizeForm(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeContextMenu();
            InitializeNotifyIcon();
        }

        private void InitializeNotifyIcon()
        {
            throw new NotImplementedException();
        }

        private void HideForm(object sender, EventArgs e)
        {
            if (form1 != null && !form1.IsDisposed)
            {
                form1.Hide();
            }
        }

        private void ShowForm(object sender, EventArgs e)
        {
            if (form1 != null && !form1.IsDisposed)
            {
                form1.Show();
                form1.WindowState = FormWindowState.Normal;
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (form1 == null || form1.IsDisposed)
                {
                    form1 = new Form1();
                    form1.FormClosed += (s, args) => form1 = null;
                    form1.Show();
                }
                else
                {
                    form1.WindowState = FormWindowState.Normal;
                    form1.Activate();
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private Label label2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private TextBox textBox1;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel3;
    }
}