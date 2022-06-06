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
    public partial class FormMoonChoice : Form
    {
        public FormMoonChoice(List<Moon> moons)
        {
            InitializeComponent();
            comboBoxMoon.Items.Clear();
            if (moons.Count == 0)
            {
                buttonOK.Enabled = false;
            }
            else
            {
                var comboSource = new Dictionary<Moon, string>();
                foreach (Moon moon in moons)
                {
                    comboSource.Add(moon, moon.Name);
                }
                comboBoxMoon.DataSource = new BindingSource(comboSource, null);
                comboBoxMoon.DisplayMember = "Value";
                comboBoxMoon.ValueMember = "Key";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
        public Moon Value
        {
            get
            {
                return ((KeyValuePair<Moon, string>)comboBoxMoon.SelectedItem).Key;
            }
        }
    }
}
