using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.businessModel;
using WinFormsApp1.businessService;

namespace WinFormsApp1.UI
{
    public partial class FormMain : Form
    {

        private string filePath;
        private static string fileFilter = "json files (*.json)|*.json|All files (*.*)|*.*";
        private Star star;
        public FormMain()
        {
            InitializeComponent();
            star = null;
            RefreshMenuState();
        }

        private void RefreshMenuState()
        {
            if (star == null)
            {
                создатьToolStripMenuItem.Enabled = true;
                открытьToolStripMenuItem.Enabled = true;
                сохранитьToolStripMenuItem.Enabled = false;
                сохранитьКакToolStripMenuItem.Enabled = false;
                выходToolStripMenuItem.Enabled = true;
                редактироватьToolStripMenuItem.Enabled = false;
            } else
            {
                создатьToolStripMenuItem.Enabled = true;
                открытьToolStripMenuItem.Enabled = true;
                сохранитьToolStripMenuItem.Enabled = true;
                сохранитьКакToolStripMenuItem.Enabled = true;
                выходToolStripMenuItem.Enabled = true;
                редактироватьToolStripMenuItem.Enabled = true;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string fileContent = reader.ReadToEnd();
                        star = StarSerializer.Deserialize(fileContent);
                        textBoxStar.Text = StarWriter.Write(star);
                        RefreshMenuState();
                    }
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(StarSerializer.Serialize(star));
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formStar = new FormStar();
            if (formStar.ShowDialog() == DialogResult.OK)
            {
                star = formStar.Value;
                textBoxStar.Text = StarWriter.Write(star);
                RefreshMenuState();
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog(); //диалоговое окно куда сохранять файл
            svf.Filter = fileFilter; //фильтр
            if (svf.ShowDialog() == DialogResult.OK)
            {
                filePath = svf.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(StarSerializer.Serialize(star));
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void планетуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPlanet = new FormPlanet();
            if (formPlanet.ShowDialog() == DialogResult.OK)
            {
                star.Planets.Add(formPlanet.Value);
                textBoxStar.Text = StarWriter.Write(star);
                RefreshMenuState();
            }
        }

        private void звездуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formStar = new FormStar();
            formStar.Value = star;
            if (formStar.ShowDialog() == DialogResult.OK)
            {
                star = formStar.Value;
                textBoxStar.Text = StarWriter.Write(star);
                RefreshMenuState();
            }
        }

        private void лунуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPlanetChoice = new FormPlanetChoice(star.Planets);
            if (formPlanetChoice.ShowDialog() == DialogResult.OK)
            {
                Planet selectedPlanet = formPlanetChoice.Value;
                var formMoon = new FormMoon();
                if (formMoon.ShowDialog() == DialogResult.OK)
                {
                    selectedPlanet.Moons.Add(formMoon.Value);
                    textBoxStar.Text = StarWriter.Write(star);
                    RefreshMenuState();
                }
            }
        }

        private void планетуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formPlanetChoice = new FormPlanetChoice(star.Planets);
            if (formPlanetChoice.ShowDialog() == DialogResult.OK)
            {
                Planet selectedPlanet = formPlanetChoice.Value;
                var formPlanet = new FormPlanet();
                formPlanet.Value = selectedPlanet;
                if (formPlanet.ShowDialog() == DialogResult.OK)
                {
                    star.Planets.Remove(selectedPlanet);
                    star.Planets.Add(formPlanet.Value);
                    textBoxStar.Text = StarWriter.Write(star);
                    RefreshMenuState();
                }
            }
        }

        private void планетуToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var formPlanetChoice = new FormPlanetChoice(star.Planets);
            if (formPlanetChoice.ShowDialog() == DialogResult.OK)
            {
                Planet selectedPlanet = formPlanetChoice.Value;
                star.Planets.Remove(selectedPlanet);
                textBoxStar.Text = StarWriter.Write(star);
                RefreshMenuState();
            }
        }

        private void лунуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formPlanetChoice = new FormPlanetChoice(star.Planets, true);
            if (formPlanetChoice.ShowDialog() == DialogResult.OK)
            {
                Planet selectedPlanet = formPlanetChoice.Value;
                var formMoonChoice = new FormMoonChoice(selectedPlanet.Moons);
                if (formMoonChoice.ShowDialog() == DialogResult.OK)
                {
                    Moon selectedMoon = formMoonChoice.Value;
                    var formMoon = new FormMoon();
                    formMoon.Value = selectedMoon;
                    if (formMoon.ShowDialog() == DialogResult.OK)
                    {
                        selectedPlanet.Moons.Remove(selectedMoon);
                        selectedPlanet.Moons.Add(formMoon.Value);
                        textBoxStar.Text = StarWriter.Write(star);
                        RefreshMenuState();
                    }
                }
            }
        }

        private void лунуToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var formPlanetChoice = new FormPlanetChoice(star.Planets, true);
            if (formPlanetChoice.ShowDialog() == DialogResult.OK)
            {
                Planet selectedPlanet = formPlanetChoice.Value;
                var formMoonChoice = new FormMoonChoice(selectedPlanet.Moons);
                if (formMoonChoice.ShowDialog() == DialogResult.OK)
                {
                    Moon selectedMoon = formMoonChoice.Value;
                    selectedPlanet.Moons.Remove(selectedMoon);
                    textBoxStar.Text = StarWriter.Write(star);
                    RefreshMenuState();
                }
            }
        }
    }
}
