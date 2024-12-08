using System;
using System.Drawing;
using System.Windows.Forms;
using Task_6;

namespace Task_6
{
    partial class Form1 : Form
    {
        private ComboBox comboBox1;

        private void InitializeComponent()
        {
            this.comboBox1 = new ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Прага",
            "Брно",
            "Острава",
            "Пльзень",
            "Ліберець",
            "Оломоуць",
            "Градець-Карлове",
            "Пардубіце"});
            this.comboBox1.Location = new Point(10, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(152, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(319, 173);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Чехія";
            this.ResumeLayout(false);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            OpenSelectedForm(selectedIndex);
        }

        private void OpenSelectedForm(int index)
        {
            switch (index)
            {
                case 0:
                    Form2 form2 = new Form2();
                    form2.Show();
                    break;
                case 1:
                    Form3 form3 = new Form3();
                    form3.Show();
                    break;
                case 2:
                    Form4 form4 = new Form4();
                    form4.Show();
                    break;
                case 3:
                    Form5 form5 = new Form5();
                    form5.Show();
                    break;
                case 4:
                    Form6 form6 = new Form6();
                    form6.Show();
                    break;
                case 5:
                    Form7 form7 = new Form7();
                    form7.Show();
                    break;
                case 6:
                    Form8 form8 = new Form8();
                    form8.Show();
                    break;
                case 7:
                    Form9 form9 = new Form9();
                    form9.Show();
                    break;
                default:
                    break;
            }
        }
    }
}

