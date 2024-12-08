using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            Form mainForm = new Form();

            // Створення ComboBox та додавання елементів
            ComboBox comboBox = new ComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Location = new System.Drawing.Point(10, 10);
            comboBox.Items.AddRange(new string[] { "Прага", "Брно", "Острава", "Пльзень", "Ліберець", "Оломоуц", "Храдець-Карлове", "Пардубіце" });

            // Обробник події вибору в ComboBox
            comboBox.SelectedIndexChanged += (sender, e) =>
            {
                // Отримати вибраний елемент
                string selectedCity = comboBox.SelectedItem.ToString();

                // Вивести відповідне місто в MsgBox
                MessageBox.Show(selectedCity, "Обране місто");
            };

            // Додавання ComboBox на форму
            mainForm.Controls.Add(comboBox);

            // Запуск програми
            Application.Run(mainForm);
        }
    }
}
