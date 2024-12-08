using System.Linq;
using System.Windows.Forms;

namespace Task_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(863, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";

            // Додаємо основні розділи 1 рівня
            ToolStripMenuItem item1 = new ToolStripMenuItem("Item1");
            ToolStripMenuItem item2 = new ToolStripMenuItem("Item2");
            ToolStripMenuItem item3 = new ToolStripMenuItem("Item3");
            ToolStripMenuItem item4 = new ToolStripMenuItem("Item4");

            // Додаємо розділи 1 рівня до меню
            menuStrip1.Items.Add(item1);
            menuStrip1.Items.Add(item2);
            menuStrip1.Items.Add(item3);
            menuStrip1.Items.Add(item4);

            // Додаємо розділи 2 рівня для кожного розділу 1 рівня
            string[] item1SecondLevel = { "Item24", "Item23", "Item22", "Item21" };
            string[] item2SecondLevel = { "Item35", "Item34", "Item33", "Item32" };
            string[] item3SecondLevel = { "Item43", "Item42", "Item41", "Item40" };
            string[] item4SecondLevel = { "Item48", "Item47", "Item46", "Item45", "Item44" };

            // Додаємо розділи 2 рівня до відповідних розділів 1 рівня
            item1.DropDownItems.AddRange(item1SecondLevel.Select(item => new ToolStripMenuItem(item)).ToArray());
            item2.DropDownItems.AddRange(item2SecondLevel.Select(item => new ToolStripMenuItem(item)).ToArray());
            item3.DropDownItems.AddRange(item3SecondLevel.Select(item => new ToolStripMenuItem(item)).ToArray());
            item4.DropDownItems.AddRange(item4SecondLevel.Select(item => new ToolStripMenuItem(item)).ToArray());

            // Додаємо розділи 3 рівня для розділів 2 рівня з розділами 3 рівня
            string[] item2ThirdLevel = { "Item311", "Item312", "Item313", "Item314" };
            string[] item3ThirdLevel = { "Item411", "Item412", "Item413" };
            string[] item4ThirdLevel = { "Item414", "Item415", "Item416", "Item417", "Item418" };

            // Розділи 2 рівня з розділами 3 рівня
            ((ToolStripMenuItem)item2.DropDownItems[3]).DropDownItems.AddRange(item2ThirdLevel.Select(item => new ToolStripMenuItem(item)).ToArray());
            ((ToolStripMenuItem)item3.DropDownItems[0]).DropDownItems.AddRange(item3ThirdLevel.Select(item => new ToolStripMenuItem(item)).ToArray());
            ((ToolStripMenuItem)item4.DropDownItems[3]).DropDownItems.AddRange(item4ThirdLevel.Select(item => new ToolStripMenuItem(item)).ToArray());

            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(863, 385);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
