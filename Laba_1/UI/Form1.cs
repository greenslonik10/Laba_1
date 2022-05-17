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

namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private string filePath;
        private static string fileFilter = "json files (*.json)|*.json|All files (*.*)|*.*";
        private Star star;

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
                    }
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
