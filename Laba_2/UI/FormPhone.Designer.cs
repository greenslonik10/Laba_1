namespace Task2.UI
{
    partial class FormPhone
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
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMemory = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMemory = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNumberOfSIM = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfSIM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfSIM)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(101, 20);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(45, 15);
            this.labelBrand.TabIndex = 0;
            this.labelBrand.Text = "Фирма";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(111, 54);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 15);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Цена";
            // 
            // labelMemory
            // 
            this.labelMemory.AutoSize = true;
            this.labelMemory.Location = new System.Drawing.Point(58, 87);
            this.labelMemory.Name = "labelMemory";
            this.labelMemory.Size = new System.Drawing.Size(88, 15);
            this.labelMemory.TabIndex = 2;
            this.labelMemory.Text = "Объем памяти";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(152, 17);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(221, 23);
            this.textBoxBrand.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(152, 51);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(221, 23);
            this.textBoxPrice.TabIndex = 4;
            // 
            // textBoxMemory
            // 
            this.textBoxMemory.Location = new System.Drawing.Point(152, 84);
            this.textBoxMemory.Name = "textBoxMemory";
            this.textBoxMemory.Size = new System.Drawing.Size(221, 23);
            this.textBoxMemory.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(111, 179);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(249, 179);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelNumberOfSIM
            // 
            this.labelNumberOfSIM.AutoSize = true;
            this.labelNumberOfSIM.Location = new System.Drawing.Point(22, 117);
            this.labelNumberOfSIM.Name = "labelNumberOfSIM";
            this.labelNumberOfSIM.Size = new System.Drawing.Size(124, 15);
            this.labelNumberOfSIM.TabIndex = 8;
            this.labelNumberOfSIM.Text = "Количество SIM-карт";
            // 
            // numericUpDownNumberOfSIM
            // 
            this.numericUpDownNumberOfSIM.Location = new System.Drawing.Point(152, 115);
            this.numericUpDownNumberOfSIM.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownNumberOfSIM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfSIM.Name = "numericUpDownNumberOfSIM";
            this.numericUpDownNumberOfSIM.Size = new System.Drawing.Size(221, 23);
            this.numericUpDownNumberOfSIM.TabIndex = 9;
            this.numericUpDownNumberOfSIM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(411, 214);
            this.Controls.Add(this.numericUpDownNumberOfSIM);
            this.Controls.Add(this.labelNumberOfSIM);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxMemory);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.labelMemory);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelBrand);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPhone";
            this.Text = "Мобильный телефон";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfSIM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelBrand;
        private Label labelPrice;
        private Label labelMemory;
        private TextBox textBoxBrand;
        private TextBox textBoxPrice;
        private TextBox textBoxMemory;
        private Button buttonOK;
        private Button buttonCancel;
        private Label labelNumberOfSIM;
        private NumericUpDown numericUpDownNumberOfSIM;
    }
}