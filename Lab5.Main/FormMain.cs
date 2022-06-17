using Lab5.Models;

namespace Lab5.Main
{
    public partial class FormMain : Form
    {
        private List<string> notifications;
        private List<VisualElement> visualElements;
        ModelPresenter modelPainter;
        // шаг, с которым будут отрисовываться модели
        private static int modelGenStep = 250;
        // количество моделей на форме
        private int modelCount;
        // максимальное количество моделей на форме
        private static int maxModelCount = 3;
        // возможные имена (для генерации моделей)
        private static string[] pedestrianNames = { "Иван", "Владимир", "Николай" };
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

        private void toolStripAddCar_Click(object sender, EventArgs e)
        {
            List<Car> cars = new List<Car>();
            // получаем координату У в зависимости от номера модели
            int yCoord = 100 + modelGenStep * modelCount;
            int crosswalkCoord = 300 + modelGenStep * modelCount;

            // получаем стартовую точку
            Point tStartPoint = new Point(200, yCoord);
            Point cStart = new Point(400, yCoord);
            Car car = new Car(modelCount + 1, Notification, tStartPoint, new CarTrace(tStartPoint, new Point(pictureBox.Width - 200, yCoord)));
            cars.Add(car);
            Pedestrian pedestrian = new Pedestrian(pedestrianNames[modelCount], Notification, cStart, new PedestrianTrace(tStartPoint, cStart));          
            

            EmergencyService emergencyService = new EmergencyService(Notification, cars, new Point(100, yCoord));
            // запускаем все элементы
            Task.Run(car.Start);
            Task.Run(pedestrian.Start);
            Task.Run(emergencyService.Start);
            // добавляем элементы для отрисовки
            modelPainter.AddVisualElem(new VisualElement(car, ImageResourse.trolley));
            modelPainter.AddVisualElem(new VisualElement(pedestrian, ImageResourse.driver));
            modelPainter.AddVisualElem(new VisualElement(emergencyService, ImageResourse.service));
            modelCount++;
            // если на форме максимальное число моделей, то делаем кнопку добавления модели недоступной
            if (modelCount >= maxModelCount)
                toolStripAddTrolley.Enabled = false;
        }
    }
}