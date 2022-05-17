namespace WinFormsApp1.UI
{
    partial class FormMoon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelDencity = new System.Windows.Forms.Label();
            this.labelOrbitRadius = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxDencity = new System.Windows.Forms.TextBox();
            this.textBoxOrbitRadius = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(67, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(111, 47);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(33, 20);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес";
            // 
            // labelDencity
            // 
            this.labelDencity.AutoSize = true;
            this.labelDencity.Location = new System.Drawing.Point(62, 80);
            this.labelDencity.Name = "labelDencity";
            this.labelDencity.Size = new System.Drawing.Size(82, 20);
            this.labelDencity.TabIndex = 2;
            this.labelDencity.Text = "Плотность";
            // 
            // labelOrbitRadius
            // 
            this.labelOrbitRadius.AutoSize = true;
            this.labelOrbitRadius.Location = new System.Drawing.Point(31, 113);
            this.labelOrbitRadius.Name = "labelOrbitRadius";
            this.labelOrbitRadius.Size = new System.Drawing.Size(113, 20);
            this.labelOrbitRadius.TabIndex = 3;
            this.labelOrbitRadius.Text = "Радиус орбиты";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(150, 11);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(204, 27);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(150, 44);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(204, 27);
            this.textBoxWeight.TabIndex = 5;
            // 
            // textBoxDencity
            // 
            this.textBoxDencity.Location = new System.Drawing.Point(150, 77);
            this.textBoxDencity.Name = "textBoxDencity";
            this.textBoxDencity.Size = new System.Drawing.Size(204, 27);
            this.textBoxDencity.TabIndex = 6;
            // 
            // textBoxOrbitRadius
            // 
            this.textBoxOrbitRadius.Location = new System.Drawing.Point(150, 110);
            this.textBoxOrbitRadius.Name = "textBoxOrbitRadius";
            this.textBoxOrbitRadius.Size = new System.Drawing.Size(204, 27);
            this.textBoxOrbitRadius.TabIndex = 7;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(67, 167);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 29);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(230, 167);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormMoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 223);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxOrbitRadius);
            this.Controls.Add(this.textBoxDencity);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelOrbitRadius);
            this.Controls.Add(this.labelDencity);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelName);
            this.Name = "FormMoon";
            this.Text = "Луна";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelDencity;
        private System.Windows.Forms.Label labelOrbitRadius;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxDencity;
        private System.Windows.Forms.TextBox textBoxOrbitRadius;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}