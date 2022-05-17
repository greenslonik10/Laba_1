namespace WinFormsApp1.UI
{
    partial class FormPlanet
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
            this.labelIsInhabited = new System.Windows.Forms.Label();
            this.labelHasAtmosphere = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.checkBoxIsInhabited = new System.Windows.Forms.CheckBox();
            this.checkBoxHasAtmosphere = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(79, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(123, 47);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(33, 20);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес";
            // 
            // labelIsInhabited
            // 
            this.labelIsInhabited.AutoSize = true;
            this.labelIsInhabited.Location = new System.Drawing.Point(80, 74);
            this.labelIsInhabited.Name = "labelIsInhabited";
            this.labelIsInhabited.Size = new System.Drawing.Size(76, 20);
            this.labelIsInhabited.TabIndex = 2;
            this.labelIsInhabited.Text = "Населена";
            // 
            // labelHasAtmosphere
            // 
            this.labelHasAtmosphere.AutoSize = true;
            this.labelHasAtmosphere.Location = new System.Drawing.Point(69, 100);
            this.labelHasAtmosphere.Name = "labelHasAtmosphere";
            this.labelHasAtmosphere.Size = new System.Drawing.Size(87, 20);
            this.labelHasAtmosphere.TabIndex = 3;
            this.labelHasAtmosphere.Text = "Атмосфера";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(162, 11);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(186, 27);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(162, 44);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(186, 27);
            this.textBoxWeight.TabIndex = 5;
            // 
            // checkBoxIsInhabited
            // 
            this.checkBoxIsInhabited.AutoSize = true;
            this.checkBoxIsInhabited.Location = new System.Drawing.Point(162, 77);
            this.checkBoxIsInhabited.Name = "checkBoxIsInhabited";
            this.checkBoxIsInhabited.Size = new System.Drawing.Size(18, 17);
            this.checkBoxIsInhabited.TabIndex = 6;
            this.checkBoxIsInhabited.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasAtmosphere
            // 
            this.checkBoxHasAtmosphere.AutoSize = true;
            this.checkBoxHasAtmosphere.Location = new System.Drawing.Point(162, 103);
            this.checkBoxHasAtmosphere.Name = "checkBoxHasAtmosphere";
            this.checkBoxHasAtmosphere.Size = new System.Drawing.Size(18, 17);
            this.checkBoxHasAtmosphere.TabIndex = 7;
            this.checkBoxHasAtmosphere.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(79, 154);
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
            this.buttonCancel.Location = new System.Drawing.Point(209, 154);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 217);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBoxHasAtmosphere);
            this.Controls.Add(this.checkBoxIsInhabited);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelHasAtmosphere);
            this.Controls.Add(this.labelIsInhabited);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPlanet";
            this.Text = "Планета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelIsInhabited;
        private System.Windows.Forms.Label labelHasAtmosphere;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.CheckBox checkBoxIsInhabited;
        private System.Windows.Forms.CheckBox checkBoxHasAtmosphere;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}