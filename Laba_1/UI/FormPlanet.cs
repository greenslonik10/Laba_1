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
    public partial class FormPlanet : Form
    {
        private Planet planet;

        public FormPlanet()
        {
            InitializeComponent();
            planet = new Planet();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                planet.Name = textBoxName.Text;
                planet.Weight = float.Parse(textBoxWeight.Text);
                planet.IsInhabited = checkBoxIsInhabited.Checked;
                planet.HasAtmosphere = checkBoxHasAtmosphere.Checked;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Некорректные данные!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        public Planet Value { 
            get { return planet; }
            set
            {
                planet = value;
                textBoxName.Text = planet.Name;
                textBoxWeight.Text = planet.Weight.ToString();
                checkBoxIsInhabited.Checked = planet.IsInhabited;
                checkBoxHasAtmosphere.Checked = planet.HasAtmosphere;
            }
        }
    }
}
