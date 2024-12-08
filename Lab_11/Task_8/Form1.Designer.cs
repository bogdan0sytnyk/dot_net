using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Task_9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHide;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            button6 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Очистити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(112, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Зберегти файл";
            button2.UseVisualStyleBackColor = true;
            button2.Click += saveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 501);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 7;
            label1.Text = "Позиція курсора: ";
            label1.MouseMove += richTextBox1_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(212, 12);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Відкрити файл";
            button3.UseVisualStyleBackColor = true;
            button3.Click += loadButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(412, 12);
            button4.Name = "button4";
            button4.Size = new Size(179, 29);
            button4.TabIndex = 10;
            button4.Text = "Позиція курсору";
            button4.UseVisualStyleBackColor = true;
            button4.Click += selectButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(312, 12);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 11;
            button5.Text = "Розробник";
            button5.UseVisualStyleBackColor = true;
            button5.Click += aboutButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 501);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 12;
            // 
            // button6
            // 
            button6.Location = new Point(597, 12);
            button6.Name = "button6";
            button6.Size = new Size(179, 29);
            button6.TabIndex = 13;
            button6.Text = "Вибор форми шрифту";
            button6.UseVisualStyleBackColor = true;
            button6.Click += fontButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 47);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(764, 451);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 530);
            Controls.Add(richTextBox1);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Текстовий редактор";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ""; // Очищаємо вміст для нового файлу
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int cursorPosition = richTextBox1.SelectionStart + 1;
            label1.Text = $"Позиція курсора: {cursorPosition}";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadFileAndDisplay();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            int cursorPosition = richTextBox1.SelectionStart;
            label1.Text = $"Позиція курсора: {cursorPosition}";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;

            richTextBox1.SelectionStart = selectionStart;
            richTextBox1.SelectionLength = selectionLength;

            richTextBox1.SelectionStart = selectionStart;
            richTextBox1.SelectionLength = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = string.Format("X: {0}, Y: {1}", e.X, e.Y);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розробник: Тюпа Павло КН 921В", "Про програму");
        }

        [Serializable]
        public class FontInfo
        {
            public string FontName { get; set; }
            public float FontSize { get; set; }
            public FontStyle FontStyle { get; set; }
            public Color FontColor { get; set; }
            // Добавьте другие свойства шрифта, если необходимо
        }

        private FontInfo currentFontInfo;

        private void SaveRtfWithFont(string rtfText)
        {
            try
            {
                using (FileStream fs = new FileStream("document.rtf", FileMode.Create))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(rtfText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні RTF: " + ex.Message);
            }
        }

        private void SaveFontInfo(FontInfo fontInfo)
        {
            try
            {
                using (FileStream fs = new FileStream("fontInfo.dat", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, fontInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні інформації про шрифт: " + ex.Message);
            }
        }

        // Метод для збереження шрифту
        private void SaveFont(Font font)
        {
            try
            {
                using (FileStream fs = new FileStream("font.dat", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, font);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні шрифту: " + ex.Message);
            }
        }

        // Метод для завантаження файлу та відображення у label
        private void LoadFileAndDisplay()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли|*.txt|Усі файли|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string txtText = File.ReadAllText(openFileDialog.FileName);
                    richTextBox1.Text = txtText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні файлу: " + ex.Message);
                }
            }
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли|*.txt|Усі файли|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
            }
        }

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label3;
        private Button button6;
        private RichTextBox richTextBox1;
    }
}