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
        private List<Car> cars;
        // возможные имена  (дл€ генерации моделей)
        private static string[] peopleNames = { "»ван", "¬ладимир", "Ќиколай", "—ергей" };
        public FormMain()
        {
            InitializeComponent();
            notifications = new List<string>();
            visualElements = new List<VisualElement>();
            cars = new List<Car>();
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
            Point fromPoint = new Point(200, 100);
            Point toPoint = new Point(pictureBox.Width - 200, fromPoint.Y);
            AddCar(fromPoint, toPoint);

            Task.Delay(100);

            fromPoint = new Point(200, 400);
            toPoint = new Point(pictureBox.Width - 200, fromPoint.Y);
            AddCar(fromPoint, toPoint);

            Task.Delay(100);

            fromPoint = new Point(200, 600);
            toPoint = new Point(pictureBox.Width - 200, fromPoint.Y);
            AddCar(fromPoint, toPoint);

            Task.Delay(100);

            fromPoint = new Point(200, 800);
            toPoint = new Point(pictureBox.Width - 200, fromPoint.Y);
            AddCar(fromPoint, toPoint);

            EmergencyService emergencyService = new EmergencyService(Notification, cars,
                         new Point(pictureBox.Width / 2 - 150, pictureBox.Height / 2));
            Task.Run(emergencyService.Start);
            modelPainter.AddVisualElem(new VisualElement(emergencyService, ImageResourse.service));


            emergencyService = new EmergencyService(Notification, cars,
                         new Point(pictureBox.Width / 2 + 150, pictureBox.Height / 2));
            Task.Run(emergencyService.Start);
            modelPainter.AddVisualElem(new VisualElement(emergencyService, ImageResourse.service));
            toolStripAddTrolley.Enabled = false;
        }

        private void AddCar(Point fromPoint, Point toPoint)
        {
            Point tStart = fromPoint;
            tStart.X = fromPoint.X + 100;
            tStart.Y = fromPoint.Y + 10;

            Crosswalk crosswalk = new Crosswalk(modelCount + 1,tStart, Notification);
            Car car = new Car(modelCount + 1, Notification, fromPoint, new CarTrace(fromPoint, toPoint));
            Crosswalker crosswalker = new Crosswalker(peopleNames[modelCount], crosswalk, car, Notification);
            cars.Add(car);

            // запускаем все элементы
            Task.Run(car.Start);
            Task.Run(crosswalker.Start);
            Task.Run(crosswalk.Start);

            modelPainter.AddVisualElem(new VisualElement(crosswalk, ImageResourse.crosswalk));
            modelPainter.AddVisualElem(new VisualElement(crosswalker, ImageResourse.crosswalker));
            modelPainter.AddVisualElem(new VisualElement(car, ImageResourse.car));
            modelCount++;
        }

    }
}