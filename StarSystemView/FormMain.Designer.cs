
namespace WinFormsApp1.UI
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
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlanetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPlanetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editStarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMoonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delPlanetToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.delMoonToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
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
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
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
            this.addPlanetToolStripMenuItem,
            this.addMoonToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // addPlanetToolStripMenuItem
            // 
            this.addPlanetToolStripMenuItem.Name = "addPlanetToolStripMenuItem";
            this.addPlanetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addPlanetToolStripMenuItem.Text = "Планету";
            this.addPlanetToolStripMenuItem.Click += new System.EventHandler(this.планетуToolStripMenuItem_Click);
            // 
            // addMoonToolStripMenuItem
            // 
            this.addMoonToolStripMenuItem.Name = "addMoonToolStripMenuItem";
            this.addMoonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addMoonToolStripMenuItem.Text = "Луну";
            this.addMoonToolStripMenuItem.Click += new System.EventHandler(this.лунуToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editStarToolStripMenuItem,
            this.editPlanetToolStripMenuItem1,
            this.editMoonToolStripMenuItem1});
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // editPlanetToolStripMenuItem1
            // 
            this.editPlanetToolStripMenuItem1.Name = "editPlanetToolStripMenuItem1";
            this.editPlanetToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.editPlanetToolStripMenuItem1.Text = "Планету";
            this.editPlanetToolStripMenuItem1.Click += new System.EventHandler(this.планетуToolStripMenuItem1_Click);
            // 
            // editStarToolStripMenuItem
            // 
            this.editStarToolStripMenuItem.Name = "editStarToolStripMenuItem";
            this.editStarToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.editStarToolStripMenuItem.Text = "Звезду";
            this.editStarToolStripMenuItem.Click += new System.EventHandler(this.звездуToolStripMenuItem_Click);
            // 
            // editMoonToolStripMenuItem1
            // 
            this.editMoonToolStripMenuItem1.Name = "editMoonToolStripMenuItem1";
            this.editMoonToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.editMoonToolStripMenuItem1.Text = "Луну";
            this.editMoonToolStripMenuItem1.Click += new System.EventHandler(this.лунуToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delPlanetToolStripMenuItem2,
            this.delMoonToolStripMenuItem2});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // delPlanetToolStripMenuItem2
            // 
            this.delPlanetToolStripMenuItem2.Name = "delPlanetToolStripMenuItem2";
            this.delPlanetToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.delPlanetToolStripMenuItem2.Text = "Планету";
            this.delPlanetToolStripMenuItem2.Click += new System.EventHandler(this.планетуToolStripMenuItem2_Click);
            // 
            // delMoonToolStripMenuItem2
            // 
            this.delMoonToolStripMenuItem2.Name = "delMoonToolStripMenuItem2";
            this.delMoonToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.delMoonToolStripMenuItem2.Text = "Луну";
            this.delMoonToolStripMenuItem2.Click += new System.EventHandler(this.лунуToolStripMenuItem2_Click);
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
            this.textBoxStar.Enabled = false;
            this.textBoxStar.Location = new System.Drawing.Point(0, 0);
            this.textBoxStar.Multiline = true;
            this.textBoxStar.Name = "textBoxStar";
            this.textBoxStar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
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
        private System.Windows.Forms.ToolStripMenuItem addPlanetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPlanetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editStarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMoonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delPlanetToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem delMoonToolStripMenuItem2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBoxStar;
    }
}

