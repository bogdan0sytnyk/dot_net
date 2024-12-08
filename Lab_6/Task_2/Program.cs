using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Task_2;

namespace YourNamespace
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Створення форми
            Form mainForm = new Form1();


            // Створення та заповнення ComboBox
            ComboBox comboBox = new ComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Location = new System.Drawing.Point(10, 10);
            comboBox.Items.AddRange(new string[] { "Чехія", "Інша країна" });
            comboBox.SelectedIndex = 0;

            // Створення та заповнення ListBox
            ListBox listBox = new ListBox();
            listBox.SelectionMode = SelectionMode.MultiSimple;
            listBox.Size = new System.Drawing.Size(120, 120);
            listBox.Location = new System.Drawing.Point(10, 30);
            listBox.Items.AddRange(new string[] { "Прага", "Брно", "Острава", "Пльзень", "Ліберець", "Оломоуц", "Храдець-Карлове", "Пардубіце" });

            // Додавання елементів на форму
            mainForm.Controls.Add(comboBox);
            mainForm.Controls.Add(listBox);

            // Обробник події вибору в ComboBox
            comboBox.SelectedIndexChanged += (sender, e) =>
            {
                int selectedIndex = comboBox.SelectedIndex;
                if (selectedIndex == 0)
                {
                    listBox.Visible = true;
                    // Якщо обрано "Варіант 1"
                }
                else if (selectedIndex == 1)
                {
                    listBox.Visible = false;
                    // Якщо обрано "Варіант 2"
                }
            };

            // Запуск програми
            Application.Run(mainForm);
        }
    }
}