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
        // возможные имена  (дл€ генерации моделей)
        private static string[] peopleNames = { "»ван", "¬ладимир", "Ќиколай" };
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
            List<Car> cars = new List<Car>();
            // получаем координату ” в зависимости от номера модели
            int yCoord = 100 + modelGenStep * modelCount;
            // получаем стартовую точку троллейбуса
            Point tStartPoint = new Point(200, yCoord);
            Crosswalk crosswalk = new Crosswalk(modelCount + 1, new Point(300, yCoord + 10), Notification);
            Car car = new Car(modelCount + 1, Notification, tStartPoint, new CarTrace(tStartPoint, new Point(pictureBox.Width - 200, yCoord)));

            Crosswalker crosswalker = new Crosswalker(peopleNames[modelCount], crosswalk, car, Notification);
            // создаем аварийную службу
            cars.Add(car);
            EmergencyService emergencyService = new EmergencyService(Notification, cars, new Point(100, yCoord));
            // запускаем все элементы
            Task.Run(car.Start);
            Task.Run(crosswalker.Start);
            Task.Run(crosswalk.Start);
            Task.Run(emergencyService.Start);
            // добавл€ем элементы дл€ отрисовки
            modelPainter.AddVisualElem(new VisualElement(crosswalk, ImageResourse.crosswalk));
            modelPainter.AddVisualElem(new VisualElement(crosswalker, ImageResourse.crosswalker));
            modelPainter.AddVisualElem(new VisualElement(car, ImageResourse.car));
            modelPainter.AddVisualElem(new VisualElement(emergencyService, ImageResourse.service));
            modelCount++;
            // если на форме максимальное число моделей, то делаем кнопку добавлени€ модели недоступной
            if (modelCount >= maxModelCount)
                toolStripAddTrolley.Enabled = false;
        }
    }
}