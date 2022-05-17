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
    public partial class FormPlanetChoice : Form
    {
        public FormPlanetChoice(List<Planet>planets, bool withMoons = false)
        {
            InitializeComponent();
            comboBoxPlanet.Items.Clear();
            var comboSource = new Dictionary<Planet, string>();
            foreach (Planet planet in planets)
            {
                if (!withMoons || planet.Moons.Count > 0)
                    comboSource.Add(planet, planet.Name);
            }
            if (comboSource.Count == 0)
            {
                buttonOK.Enabled = false;
            }
            else
            {
                comboBoxPlanet.DataSource = new BindingSource(comboSource, null);
                comboBoxPlanet.DisplayMember = "Value";
                comboBoxPlanet.ValueMember = "Key";
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
        public Planet Value
        {
            get {
                return ((KeyValuePair<Planet, string>)comboBoxPlanet.SelectedItem).Key;
            }
        }
    }
}
