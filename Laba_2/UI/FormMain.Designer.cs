namespace Task2.UI
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
            this.toolStripMenuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCreateFirstLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCreateSecondLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMian = new System.Windows.Forms.Panel();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panelMian.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCreate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // toolStripMenuItemCreate
            // 
            this.toolStripMenuItemCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCreateFirstLevel,
            this.toolStripMenuItemCreateSecondLevel});
            this.toolStripMenuItemCreate.Name = "toolStripMenuItemCreate";
            this.toolStripMenuItemCreate.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItemCreate.Text = "Создать";
            // 
            // toolStripMenuItemCreateFirstLevel
            // 
            this.toolStripMenuItemCreateFirstLevel.Name = "toolStripMenuItemCreateFirstLevel";
            this.toolStripMenuItemCreateFirstLevel.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItemCreateFirstLevel.Text = "Объект 1-го уровня";
            this.toolStripMenuItemCreateFirstLevel.Click += new System.EventHandler(this.toolStripMenuItemCreateFirstLevel_Click);
            // 
            // toolStripMenuItemCreateSecondLevel
            // 
            this.toolStripMenuItemCreateSecondLevel.Name = "toolStripMenuItemCreateSecondLevel";
            this.toolStripMenuItemCreateSecondLevel.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItemCreateSecondLevel.Text = "Объект 2-го уровня";
            this.toolStripMenuItemCreateSecondLevel.Click += new System.EventHandler(this.toolStripMenuItemCreateSecondLevel_Click);
            // 
            // panelMian
            // 
            this.panelMian.Controls.Add(this.textBoxMain);
            this.panelMian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMian.Location = new System.Drawing.Point(0, 24);
            this.panelMian.Name = "panelMian";
            this.panelMian.Size = new System.Drawing.Size(800, 426);
            this.panelMian.TabIndex = 1;
            // 
            // textBoxMain
            // 
            this.textBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMain.Location = new System.Drawing.Point(0, 0);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(800, 426);
            this.textBoxMain.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMian);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Задание 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMian.ResumeLayout(false);
            this.panelMian.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItemCreate;
        private ToolStripMenuItem toolStripMenuItemCreateFirstLevel;
        private ToolStripMenuItem toolStripMenuItemCreateSecondLevel;
        private Panel panelMian;
        private TextBox textBoxMain;
    }
}