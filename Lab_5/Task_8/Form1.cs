using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();
        Button button4 = new Button();
        Button button5 = new Button();
        TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel4 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel3 = new TableLayoutPanel();
        TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel();
        private void Form1_Load(object sender, EventArgs e)
        {

            button1.Location = new System.Drawing.Point(3, 3);
            button1.Name = "button3";
            button1.Size = new System.Drawing.Size(110, 110);
            button1.TabIndex = 0;
            button1.Text = "button3";
            button1.UseVisualStyleBackColor = true;

            button2.Location = new System.Drawing.Point(3, 3);
            button2.Name = "button1";
            button2.Size = new System.Drawing.Size(110, 110);
            button2.TabIndex = 1;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;


            button3.Location = new System.Drawing.Point(3, 92);
            button3.Name = "button5";
            button3.Size = new System.Drawing.Size(110, 110);
            button3.TabIndex = 2;
            button3.Text = "button5";
            button3.UseVisualStyleBackColor = true;

            button4.Location = new System.Drawing.Point(3, 3);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(110, 110);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;

            button5.Location = new System.Drawing.Point(3, 3);
            button5.Name = "button2";
            button5.Size = new System.Drawing.Size(110, 110);
            button5.TabIndex = 4;
            button5.Text = "button2";
            button5.UseVisualStyleBackColor = true;

            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(110, 220);
            tableLayoutPanel1.TabIndex = 5;

            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(12, 230);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(110, 110);
            tableLayoutPanel2.TabIndex = 6;

            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(button4, 0, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(515, 12);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(110, 110);
            tableLayoutPanel3.TabIndex = 7;

            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(button5, 0, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(302, 230);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new System.Drawing.Size(110, 110);
            tableLayoutPanel4.TabIndex = 7;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(736, 350);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
        }
    }
}
