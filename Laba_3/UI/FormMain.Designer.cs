namespace ProjectShip.UI
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.textBoxShips = new System.Windows.Forms.TextBox();
            this.numericUpDownNum = new System.Windows.Forms.NumericUpDown();
            this.labelNum = new System.Windows.Forms.Label();
            this.buttonAtack = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonLand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxShips);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.buttonLand);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonStart);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonReload);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonAtack);
            this.splitContainerMain.Panel2.Controls.Add(this.numericUpDownNum);
            this.splitContainerMain.Panel2.Controls.Add(this.labelNum);
            this.splitContainerMain.Size = new System.Drawing.Size(1009, 595);
            this.splitContainerMain.SplitterDistance = 336;
            this.splitContainerMain.TabIndex = 0;
            // 
            // textBoxShips
            // 
            this.textBoxShips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxShips.Location = new System.Drawing.Point(0, 0);
            this.textBoxShips.Multiline = true;
            this.textBoxShips.Name = "textBoxShips";
            this.textBoxShips.ReadOnly = true;
            this.textBoxShips.Size = new System.Drawing.Size(336, 595);
            this.textBoxShips.TabIndex = 0;
            // 
            // numericUpDownNum
            // 
            this.numericUpDownNum.Location = new System.Drawing.Point(123, 21);
            this.numericUpDownNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNum.Name = "numericUpDownNum";
            this.numericUpDownNum.Size = new System.Drawing.Size(227, 23);
            this.numericUpDownNum.TabIndex = 1;
            this.numericUpDownNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(13, 23);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(94, 15);
            this.labelNum.TabIndex = 0;
            this.labelNum.Text = "Номер корабля";
            // 
            // buttonAtack
            // 
            this.buttonAtack.Location = new System.Drawing.Point(13, 59);
            this.buttonAtack.Name = "buttonAtack";
            this.buttonAtack.Size = new System.Drawing.Size(135, 23);
            this.buttonAtack.TabIndex = 2;
            this.buttonAtack.Text = "Залп";
            this.buttonAtack.UseVisualStyleBackColor = true;
            this.buttonAtack.Click += new System.EventHandler(this.buttonAtack_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(13, 88);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(135, 23);
            this.buttonReload.TabIndex = 3;
            this.buttonReload.Text = "Перезарядить";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(215, 59);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(135, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Запустить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonLand
            // 
            this.buttonLand.Location = new System.Drawing.Point(215, 88);
            this.buttonLand.Name = "buttonLand";
            this.buttonLand.Size = new System.Drawing.Size(135, 23);
            this.buttonLand.TabIndex = 5;
            this.buttonLand.Text = "Посадить";
            this.buttonLand.UseVisualStyleBackColor = true;
            this.buttonLand.Click += new System.EventHandler(this.buttonLand_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 595);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "FormMain";
            this.Text = "Корабли";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainerMain;
        private TextBox textBoxShips;
        private NumericUpDown numericUpDownNum;
        private Label labelNum;
        private Button buttonLand;
        private Button buttonStart;
        private Button buttonReload;
        private Button buttonAtack;
    }
}