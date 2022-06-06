using Laba_5.model;
using Laba_6.UI;

namespace Laba_5.UI
{
    public partial class FormMain : Form
    {
        private List<string> notifications;
        private List<VisualElement> visualElements;
        ModelPresenter modelPainter;
        // количество моделей на форме
        private int modelCount;
        // возможные имена водителей (для генерации моделей)
        private static string[] driverNames = { "Иван", "Владимир", "Николай", "Пётр" };
        private List<Trolleybus> trolleys;
        public FormMain()
        {
            InitializeComponent();
            notifications = new List<string>();
            visualElements = new List<VisualElement>();
            trolleys = new List<Trolleybus>();
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
            Point fromPoint = new Point(300, 100);
            Point toPoint = new Point(pictureBox.Width - 300, fromPoint.Y);
            AddTrolley(fromPoint, toPoint);

            fromPoint = new Point(pictureBox.Width - 100, 300);
            toPoint = new Point(fromPoint.X, pictureBox.Height - 300);
            AddTrolley(fromPoint, toPoint);

            fromPoint = new Point(pictureBox.Width - 300, pictureBox.Height - 100);
            toPoint = new Point(300, fromPoint.Y);
            AddTrolley(fromPoint, toPoint);

            fromPoint = new Point(100, pictureBox.Height - 300);
            toPoint = new Point(fromPoint.X, 300);
            AddTrolley(fromPoint, toPoint);

            EmergencyService emergencyService = new EmergencyService(Notification, trolleys,
                         new Point(pictureBox.Width / 2 - 150, pictureBox.Height / 2));
            Task.Run(emergencyService.Start);
            modelPainter.AddVisualElem(new VisualElement(emergencyService, ImageResourse.service));


            emergencyService = new EmergencyService(Notification, trolleys,
                         new Point(pictureBox.Width / 2 + 150, pictureBox.Height / 2));
            Task.Run(emergencyService.Start);
            modelPainter.AddVisualElem(new VisualElement(emergencyService, ImageResourse.service));
            toolStripRun.Enabled = false;
        }
        private void AddTrolley(Point fromPoint, Point toPoint)
        {
            // создаем объект троллейбус
            Trolleybus trolleybus =
                new Trolleybus(modelCount + 1, Notification, fromPoint, new TrolleyTrace(fromPoint, toPoint));
            // создаем водителя
            Driver driver = new Driver(driverNames[modelCount], trolleybus, Notification);

            trolleys.Add(trolleybus);
            Task.Run(trolleybus.Start);
            Task.Run(driver.Start);
            modelPainter.AddVisualElem(new VisualElement(trolleybus, ImageResourse.trolley));
            modelPainter.AddVisualElem(new VisualElement(driver, ImageResourse.driver));
            modelCount++;
        }
    }
}