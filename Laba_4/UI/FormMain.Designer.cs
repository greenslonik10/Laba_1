namespace ProjectShip.UI
{
    partial class FormMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonActivateMethod = new System.Windows.Forms.Button();
            this.buttonNewObject = new System.Windows.Forms.Button();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.textBoxObjectInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonActivateMethod);
            this.splitContainer1.Panel1.Controls.Add(this.buttonNewObject);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxMethod);
            this.splitContainer1.Panel1.Controls.Add(this.labelMethod);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxClass);
            this.splitContainer1.Panel1.Controls.Add(this.labelClass);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxObjectInfo);
            this.splitContainer1.Size = new System.Drawing.Size(850, 404);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonActivateMethod
            // 
            this.buttonActivateMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonActivateMethod.Location = new System.Drawing.Point(154, 351);
            this.buttonActivateMethod.Name = "buttonActivateMethod";
            this.buttonActivateMethod.Size = new System.Drawing.Size(109, 41);
            this.buttonActivateMethod.TabIndex = 5;
            this.buttonActivateMethod.Text = "Выполнить метод";
            this.buttonActivateMethod.UseVisualStyleBackColor = true;
            this.buttonActivateMethod.Click += new System.EventHandler(this.buttonActivateMethod_Click);
            // 
            // buttonNewObject
            // 
            this.buttonNewObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNewObject.Location = new System.Drawing.Point(12, 351);
            this.buttonNewObject.Name = "buttonNewObject";
            this.buttonNewObject.Size = new System.Drawing.Size(110, 41);
            this.buttonNewObject.TabIndex = 4;
            this.buttonNewObject.Text = "Новый объект";
            this.buttonNewObject.UseVisualStyleBackColor = true;
            this.buttonNewObject.Click += new System.EventHandler(this.buttonNewObject_Click);
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Location = new System.Drawing.Point(12, 89);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(235, 23);
            this.comboBoxMethod.TabIndex = 3;
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(12, 71);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(42, 15);
            this.labelMethod.TabIndex = 2;
            this.labelMethod.Text = "Метод";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(12, 27);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(235, 23);
            this.comboBoxClass.TabIndex = 1;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(12, 9);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(39, 15);
            this.labelClass.TabIndex = 0;
            this.labelClass.Text = "Класс";
            // 
            // textBoxObjectInfo
            // 
            this.textBoxObjectInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxObjectInfo.Enabled = false;
            this.textBoxObjectInfo.Location = new System.Drawing.Point(0, 0);
            this.textBoxObjectInfo.Multiline = true;
            this.textBoxObjectInfo.Name = "textBoxObjectInfo";
            this.textBoxObjectInfo.Size = new System.Drawing.Size(564, 404);
            this.textBoxObjectInfo.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 404);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.Text = "Задание 4";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ComboBox comboBoxMethod;
        private Label labelMethod;
        private ComboBox comboBoxClass;
        private Label labelClass;
        private TextBox textBoxObjectInfo;
        private Button buttonActivateMethod;
        private Button buttonNewObject;
    }
}