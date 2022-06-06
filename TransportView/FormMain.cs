using Laba_5.model;
using System.Drawing;

namespace Laba_5.UI
{
    public partial class FormMain : Form
    {
        private List<string> notifications;
        private List<VisualElement> visualElements;
        ModelPresenter modelPainter;
        // шаг, с которым будут отрисовыватьс€ модели
        private static int modelGenStep = 250;
        // количество моделей на форме
        private int modelCount;
        // максимальное количество моделей на форме
        private static int maxModelCount = 3;
        // возможные имена водителей (дл€ генерации моделей)
        private static string[] driverNames = { "»ван", "¬ладимир", "Ќиколай" };
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
            // получаем координату ” в зависимости от номера модели
            int yCoord = 100 + modelGenStep * modelCount;
            // получаем стартовую точку троллейбуса
            Point tStartPoint = new Point(200, yCoord);
            // создаем объект троллейбус
            Trolleybus trolleybus =
                new Trolleybus(modelCount + 1, Notification, tStartPoint, new TrolleyTrace(tStartPoint, new Point(pictureBox.Width - 200, yCoord)));
            // создаем водител€
            Driver driver = new Driver(driverNames[modelCount], trolleybus, Notification);
            // создаем аварийную службу
            trolleys.Add(trolleybus);
            EmergencyService emergencyService = new EmergencyService(Notification, trolleys,
                         new Point(100, yCoord));
            // запускаем все элементы
            Task.Run(trolleybus.Start);
            Task.Run(driver.Start);
            Task.Run(emergencyService.Start);
            // добавл€ем элементы дл€ отрисовки
            modelPainter.AddVisualElem(new VisualElement(trolleybus, ImageResourse.trolley));
            modelPainter.AddVisualElem(new VisualElement(driver, ImageResourse.driver));
            modelPainter.AddVisualElem(new VisualElement(emergencyService, ImageResourse.service));
            modelCount++;
            // если на форме максимальное число моделей, то делаем кнопку добавлени€ модели недоступной
            if (modelCount >= maxModelCount)
                toolStripAddTrolley.Enabled = false;
        }
    }
}