using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task_1
{
    partial class Form1 : Form
    {
        private List<UserData> users = new List<UserData>();

        public static UserData loggedInUser; // Публичное поле для доступа к данным пользователя

        // Ваш существующий код

        public void UpdateUserData(UserData updatedUser)
        {
            loggedInUser = updatedUser;
            // Обновите другие элементы, если необходимо
        }

        public static UserData GetUpdatedUserData()
        {
            return CurrentUser; // Возвращаем текущего пользователя
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 475);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(241, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(242, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(243, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(240, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(414, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "policy.";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(240, 286);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(240, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 22);
            this.textBox2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(196, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bycliking register you agree to our";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Register\r\nor Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(79, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(79, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(79, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(79, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Registration";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 49);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 499);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Khpgram";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            // Створюємо градієнтний кисть
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                groupBox1.ClientRectangle,
                Color.White, // Верхній колір (білий)
                Color.Green, // Нижній колір (зелений)
                LinearGradientMode.Vertical); // Вказуємо вертикальний градієнт

            // Використовуючи кисть, заповнюємо прямокутник градієнтом
            e.Graphics.FillRectangle(gradientBrush, groupBox1.ClientRectangle);
        }

        public class UserData
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
        }

        public static UserData CurrentUser { get; private set; }

        private string[] existingFirstNames = { "John", "Jane", "Bob", "Alice" };
        private string[] existingLastNames = { "Doe", "Smith", "Johnson", "Brown" };

        private bool IsFirstNameUnique(string firstName)
        {
            return !existingFirstNames.Contains(firstName);
        }

        private bool IsLastNameUnique(string lastName)
        {
            return !existingLastNames.Contains(lastName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox3.Text;
            string password = textBox4.Text;
            string lastName = textBox2.Text;
            string email = textBox1.Text;

            bool isValidUserName = IsValidUserName(userName);
            bool isValidPassword = IsValidPassword(password);
            bool isValidLastName = IsValidLastName(lastName);
            bool isValidEmail = IsValidEmail(email);

            bool isFirstNameUnique = IsFirstNameUnique(userName);
            bool isLastNameUnique = IsLastNameUnique(lastName);

            // Сбрасываем видимость всех лейблов перед проверкой
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

            if (isValidUserName && isValidPassword && isValidLastName && isValidEmail && isFirstNameUnique && isLastNameUnique)
            {
                UserData newUser = new UserData
                {
                    FirstName = textBox3.Text,
                    LastName = textBox2.Text,
                    UserName = $"{userName} {lastName}",
                    Password = textBox4.Text,
                    Email = textBox1.Text
                };

                if (Form1.loggedInUser != null && Form1.loggedInUser.Email == email)
                {
                    // Если пользователь с таким email уже существует, обновляем его данные
                    Form1.loggedInUser = newUser;
                }
                else
                {
                    // Если пользователь новый, добавляем его в список
                    users.Add(newUser);
                    Form1.loggedInUser = newUser;
                }

                // Відкрити Form2
                Form2 form2 = new Form2(newUser); // Передаємо список користувачів до Form2
                form2.Show();
                this.Hide(); // Приховуємо поточну форму
            }
            else
            {
                // Показати повідомлення про помилку для кожного невалідного поля

                if (!isValidUserName)
                {
                    label8.Text = "Invalid First Name";
                    label8.Visible = true;
                }

                if (!isFirstNameUnique)
                {
                    label8.Text = "Name already exists";
                    label8.Visible = true;
                }

                if (!isValidPassword)
                {
                    label11.Text = "Invalid Password";
                    label11.Visible = true;
                }

                if (!isValidLastName)
                {
                    label10.Text = "Invalid Last Name";
                    label10.Visible = true;
                }

                if (!isLastNameUnique)
                {
                    label10.Text = "Last Name already exists";
                    label10.Visible = true;
                }

                if (!isValidEmail)
                {
                    label9.Text = "Invalid Email";
                    label9.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private bool IsValidUserName(string firstName)
        {
            return !string.IsNullOrWhiteSpace(firstName) && IsAlphaNumeric(firstName);
        }

        private bool IsValidLastName(string lastName)
        {
            return !string.IsNullOrWhiteSpace(lastName) && IsAlphaNumeric(lastName);
        }

        private bool IsAlphaNumeric(string input)
        {
            return !Regex.IsMatch(input, @"[^a-zA-Z0-9]");
        }

        private bool IsValidPassword(string password)
        {
            return !string.IsNullOrWhiteSpace(password) && password.Length >= 12 && ContainsSpecialCharacter(password);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool ContainsSpecialCharacter(string input)
        {
            return Regex.IsMatch(input, @"[!@#$%^&*(),.?\:{ }|<>]");
        }

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button button2;
    }
}

