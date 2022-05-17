using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2.Model;

namespace Task2.UI
{
    public enum Level
    {
        First,
        Second
    }

    public partial class FormPhone : Form
    {
        private string brand = "";

        private float price = 0;

        private float memory = 0;

        private int numberOfSIM = 1;

        private Level level;

        public FormPhone(Level level)
        {
            InitializeComponent();
            this.level = level;
            if (level == Level.First)
            {
                labelNumberOfSIM.Visible = false;
                numericUpDownNumberOfSIM.Visible = false;
            } else
            {
                labelNumberOfSIM.Visible = true;
                numericUpDownNumberOfSIM.Visible = true;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                brand = textBoxBrand.Text;
                price = float.Parse(textBoxPrice.Text);
                memory = float.Parse(textBoxMemory.Text);
                numberOfSIM = Decimal.ToInt32(numericUpDownNumberOfSIM.Value);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Некорректные данные!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        public MobilePhone Value
        {
            get
            {
                if (level == Level.First)
                {
                    return new MobilePhone(brand, price, memory);
                } else
                {
                    return new MobilePhoneSIM(brand, price, memory, numberOfSIM);
                }
            }
        }
    }
}
