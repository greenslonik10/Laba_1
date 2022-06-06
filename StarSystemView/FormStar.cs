using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.businessModel;

namespace WinFormsApp1.UI
{
    public partial class FormStar : Form
    {
        private Star star;

        public FormStar()
        {
            InitializeComponent();
            star = new Star();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                star.Name = textBoxName.Text;
                star.Weight = float.Parse(textBoxWeight.Text);
                star.Temperature = Decimal.ToInt32(numericUpDownTemperature.Value);
                star.Age = Decimal.ToInt32(numericUpDownAge.Value);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch {
                MessageBox.Show("Некорректные данные!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Star Value { 
            get { return star; } 
            set
            {
                star = value;
                textBoxName.Text = star.Name;
                textBoxWeight.Text = star.Weight.ToString();
                numericUpDownTemperature.Value = star.Temperature;
                numericUpDownAge.Value = star.Age;
            }
        }
    }
}
