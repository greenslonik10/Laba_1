
namespace WinFormsApp1
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.планетуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лунуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.планетуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.звездуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лунуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.планетуToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.лунуToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.textBoxStar = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1331, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.планетуToolStripMenuItem,
            this.лунуToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.планетуToolStripMenuItem1,
            this.звездуToolStripMenuItem,
            this.лунуToolStripMenuItem1});
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.планетуToolStripMenuItem2,
            this.лунуToolStripMenuItem2});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // планетуToolStripMenuItem
            // 
            this.планетуToolStripMenuItem.Name = "планетуToolStripMenuItem";
            this.планетуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.планетуToolStripMenuItem.Text = "Планету";
            // 
            // лунуToolStripMenuItem
            // 
            this.лунуToolStripMenuItem.Name = "лунуToolStripMenuItem";
            this.лунуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.лунуToolStripMenuItem.Text = "Луну";
            // 
            // планетуToolStripMenuItem1
            // 
            this.планетуToolStripMenuItem1.Name = "планетуToolStripMenuItem1";
            this.планетуToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.планетуToolStripMenuItem1.Text = "Планету";
            // 
            // звездуToolStripMenuItem
            // 
            this.звездуToolStripMenuItem.Name = "звездуToolStripMenuItem";
            this.звездуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.звездуToolStripMenuItem.Text = "Звезду";
            // 
            // лунуToolStripMenuItem1
            // 
            this.лунуToolStripMenuItem1.Name = "лунуToolStripMenuItem1";
            this.лунуToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.лунуToolStripMenuItem1.Text = "Луну";
            // 
            // планетуToolStripMenuItem2
            // 
            this.планетуToolStripMenuItem2.Name = "планетуToolStripMenuItem2";
            this.планетуToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.планетуToolStripMenuItem2.Text = "Планету";
            // 
            // лунуToolStripMenuItem2
            // 
            this.лунуToolStripMenuItem2.Name = "лунуToolStripMenuItem2";
            this.лунуToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.лунуToolStripMenuItem2.Text = "Луну";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.textBoxStar);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 28);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1331, 621);
            this.panelMain.TabIndex = 1;
            // 
            // textBoxStar
            // 
            this.textBoxStar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStar.Location = new System.Drawing.Point(0, 0);
            this.textBoxStar.Multiline = true;
            this.textBoxStar.Name = "textBoxStar";
            this.textBoxStar.Size = new System.Drawing.Size(1331, 621);
            this.textBoxStar.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 649);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Звездная Система";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem планетуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лунуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem планетуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem звездуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лунуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem планетуToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem лунуToolStripMenuItem2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBoxStar;
    }
}

