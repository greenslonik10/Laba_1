using Laba_5.model;
using System.Drawing;

namespace Laba_5.UI
{
    public partial class FormMain : Form
    {
        private List<string> notifications;
        private List<VisualElement> visualElements;
        ModelPresenter modelPainter;
        // ���, � ������� ����� �������������� ������
        private static int modelGenStep = 250;
        // ���������� ������� �� �����
        private int modelCount;
        // ������������ ���������� ������� �� �����
        private static int maxModelCount = 3;
        // ��������� ����� ��������� (��� ��������� �������)
        private static string[] driverNames = { "����", "��������", "�������" };
        public FormMain()
        {
            InitializeComponent();
            notifications = new List<string>();
            visualElements = new List<VisualElement>();
            modelPainter = new ModelPresenter(pictureBox, visualElements);
            modelCount = 0;
            modelPainter.Start();
        }

        void Notification(string message)
        {
            textBoxNotifications.Invoke((MethodInvoker)delegate
            {
                notifications.Add(message);
                if (notifications.Count >= 15)
                {
                    notifications = notifications.GetRange(notifications.Count - 5, 5);
                    textBoxNotifications.Text = "";
                    foreach (var item in notifications)
                    {
                        textBoxNotifications.Text += item + Environment.NewLine + Environment.NewLine;
                    }
                }
                textBoxNotifications.Text += message + Environment.NewLine + Environment.NewLine;
            });
        }

        private void toolStripAddTrolley_Click(object sender, EventArgs e)
        {
            List<Trolleybus> trolleys = new List<Trolleybus>();
            // �������� ���������� � � ����������� �� ������ ������
            int yCoord = 100 + modelGenStep * modelCount;
            // �������� ��������� ����� �����������
            Point tStartPoint = new Point(200, yCoord);
            // ������� ������ ����������
            Trolleybus trolleybus =
                new Trolleybus(modelCount + 1, Notification, tStartPoint, new TrolleyTrace(tStartPoint, new Point(pictureBox.Width - 200, yCoord)));
            // ������� ��������
            Driver driver = new Driver(driverNames[modelCount], trolleybus, Notification);
            // ������� ��������� ������
            trolleys.Add(trolleybus);
            EmergencyService emergencyService = new EmergencyService(Notification, trolleys,
                         new Point(100, yCoord));
            // ��������� ��� ��������
            Task.Run(trolleybus.Start);
            Task.Run(driver.Start);
            Task.Run(emergencyService.Start);
            // ��������� �������� ��� ���������
            modelPainter.AddVisualElem(new VisualElement(trolleybus, ImageResourse.trolley));
            modelPainter.AddVisualElem(new VisualElement(driver, ImageResourse.driver));
            modelPainter.AddVisualElem(new VisualElement(emergencyService, ImageResourse.service));
            modelCount++;
            // ���� �� ����� ������������ ����� �������, �� ������ ������ ���������� ������ �����������
            if (modelCount >= maxModelCount)
                toolStripAddTrolley.Enabled = false;
        }
    }
}