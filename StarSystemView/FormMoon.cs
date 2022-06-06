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
    public partial class FormMoon : Form
    {
        private Moon moon;
        public FormMoon()
        {
            InitializeComponent();
            moon = new Moon();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                moon.Name = textBoxName.Text;
                moon.Weight = float.Parse(textBoxWeight.Text);
                moon.Density = float.Parse(textBoxDencity.Text);
                moon.OrbitRadius = float.Parse(textBoxOrbitRadius.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Некорректные данные!", "Ошибка", MessageBoxButtons.OK);
            }
        }
        public Moon Value
        {
            get { return moon; }
            set
            {
                moon = value;
                textBoxName.Text = moon.Name;
                textBoxWeight.Text = moon.Weight.ToString();
                textBoxDencity.Text = moon.Density.ToString();
                textBoxOrbitRadius.Text = moon.OrbitRadius.ToString();
            }
        }
    }
}
