using ProjectShip.model;

namespace ProjectShip.UI
{
    public partial class FormMain : Form
    {
        private List<IShip> ships;
        public FormMain()
        {
            ships = new List<IShip>();
            ships.Add(new Aerocarrier("Быстрый", 100, 3, 10, 60));
            ships.Add(new Aerocarrier("Стремительный", 150, 5, 15, 70));
            ships.Add(new Aerocarrier("Отважный", 200, 7, 20, 100));
            InitializeComponent();
            printShipsToTB();
            numericUpDownNum.Maximum = ships.Count;
        }

        private void printShipsToTB()
        {
            textBoxShips.Text = "";
            for (int i = 0; i < ships.Count; i++)
            {
                textBoxShips.Text += "Номер: " + (i + 1) + Environment.NewLine +
                    ships[i].ToString() + Environment.NewLine + Environment.NewLine;
            }
        }

        private void buttonAtack_Click(object sender, EventArgs e)
        {
            int index = Decimal.ToInt32(numericUpDownNum.Value) - 1;
            if ((ships[index] is Aerocarrier) && ((Aerocarrier)ships[index]).TryAtack())
            {
                printShipsToTB();
            }
            else
            {
                MessageBox.Show("Действие невозможно!");
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            int index = Decimal.ToInt32(numericUpDownNum.Value) - 1;
            if ((ships[index] is Aerocarrier) && ((Aerocarrier)ships[index]).TryReload())
            {
                printShipsToTB();
            }
            else
            {
                MessageBox.Show("Действие невозможно!");
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int index = Decimal.ToInt32(numericUpDownNum.Value) - 1;
            if ((ships[index] is Aerocarrier) && ((Aerocarrier)ships[index]).TryStartJet())
            {
                printShipsToTB();
            }
            else
            {
                MessageBox.Show("Действие невозможно!");
            }
        }

        private void buttonLand_Click(object sender, EventArgs e)
        {
            int index = Decimal.ToInt32(numericUpDownNum.Value) - 1;
            if ((ships[index] is Aerocarrier) && ((Aerocarrier)ships[index]).TryLandJat())
            {
                printShipsToTB();
            }
            else
            {
                MessageBox.Show("Действие невозможно!");
            }
        }
    }
}