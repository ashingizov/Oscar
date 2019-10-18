namespace Srs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.конверторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.конверторToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.конверторToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // конверторToolStripMenuItem
            // 
            this.конверторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.конверторToolStripMenuItem1,
            this.таблицаToolStripMenuItem1,
            this.инфоToolStripMenuItem1});
            this.конверторToolStripMenuItem.Name = "конверторToolStripMenuItem";
            this.конверторToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.конверторToolStripMenuItem.Text = "Меню";
            this.конверторToolStripMenuItem.Click += new System.EventHandler(this.КонверторToolStripMenuItem_Click);
            // 
            // таблицаToolStripMenuItem1
            // 
            this.таблицаToolStripMenuItem1.Name = "таблицаToolStripMenuItem1";
            this.таблицаToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.таблицаToolStripMenuItem1.Text = "Таблица";
            this.таблицаToolStripMenuItem1.Click += new System.EventHandler(this.ТаблицаToolStripMenuItem1_Click);
            // 
            // инфоToolStripMenuItem1
            // 
            this.инфоToolStripMenuItem1.Name = "инфоToolStripMenuItem1";
            this.инфоToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.инфоToolStripMenuItem1.Text = "Инфо";
            this.инфоToolStripMenuItem1.Click += new System.EventHandler(this.ИнфоToolStripMenuItem1_Click);
            // 
            // конверторToolStripMenuItem1
            // 
            this.конверторToolStripMenuItem1.Name = "конверторToolStripMenuItem1";
            this.конверторToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.конверторToolStripMenuItem1.Text = "Конвертор";
            this.конверторToolStripMenuItem1.Click += new System.EventHandler(this.КонверторToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem конверторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem инфоToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem конверторToolStripMenuItem1;
    }
}

