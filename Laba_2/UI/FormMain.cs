using Task2.Model;

namespace Task2.UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemCreateFirstLevel_Click(object sender, EventArgs e)
        {
            var formPhone = new FormPhone(Level.First);
            if (formPhone.ShowDialog() == DialogResult.OK)
            {
                MobilePhone mp = formPhone.Value;
                textBoxMain.Text = mp.ToString();
            }
        }

        private void toolStripMenuItemCreateSecondLevel_Click(object sender, EventArgs e)
        {
            var formPhone = new FormPhone(Level.Second);
            if (formPhone.ShowDialog() == DialogResult.OK)
            {
                MobilePhone mp = formPhone.Value;
                textBoxMain.Text = mp.ToString();
            }
        }
    }
}