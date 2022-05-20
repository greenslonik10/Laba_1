using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectShip.UI
{
    public partial class FormInputNum : Form
    {
        private int value;

        public int Value { get { return value; } }
        public FormInputNum(string promt)
        {
            InitializeComponent();
            labelPromt.Text = "Параметр " + promt;
        }

        private void numericUpDownValue_ValueChanged(object sender, EventArgs e)
        {
            value = Decimal.ToInt32(numericUpDownValue.Value);
        }
    }
}
