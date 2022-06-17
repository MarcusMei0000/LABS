using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using InputString;
using Lab5.Models;
using System.Reflection;

namespace Lab5.Main
{
    public partial class MainForm : Form
    {
        // будем хранить список всех объектов, которые будем отрисоываать
        List<ViewObject> viewObjects;
        object viewObjectsLocker;

        List<ViewModel> viewModels;
        object viewModelsLocker;

        // рисователь всех объектов
        Painter painter;

        //здания на карте

        ViewObject hospital, gym;

        // спросмены
        List<Sportsman> sportsmans;
        object sportsmansLocker;

        // соревнования
        List<Competition> competitions;

        // соревнования будут только в в левой части экрана находится

        int maxCompetitionsNumber;

        IEnumerable<Type> doctorTypes;

        // будем хранить все уведомления, чтобы их постепенно очищать
        List<string> notifications;

        // картинки моделей
        // лучше сделать ссылки на них, так проще будет изменять код при изменении картинок
        Image sportsmanImage,
            doctorImage,
            gymImage,
            stadiumImage,
            hospitalImage;

        public MainForm()
        {
            InitializeComponent();

            InitImages();

            viewObjects = new List<ViewObject>();
            viewObjectsLocker = new object();

            viewModels = new List<ViewModel>();
            viewModelsLocker = new object();

            sportsmans = new List<Sportsman>();
            sportsmansLocker = new object();

            doctorTypes = Assembly.Load("Lab6.Models").GetTypes()
                .Where(type => !type.IsAbstract && type.GetInterface("IDoctor") != null);

            notifications = new List<string>();

            maxCompetitionsNumber = (int)(pictureBox.Height / stadiumImage.Height);

            competitions = new List<Competition>();
        }

        void InitImages()
        {
            sportsmanImage = Properties.Resources.Sportsman;
            doctorImage = Properties.Resources.Doctor;
            gymImage = Properties.Resources.Gym;
            stadiumImage = Properties.Resources.Stadium;
            hospitalImage = Properties.Resources.Hospital;
        }

        void Notification(string message)
        {
            notificationTextBox.Invoke((MethodInvoker)delegate
            {
                notifications.Add(message);

                if (notifications.Count >= 15)
                {
                    // clear
                    notifications = notifications.GetRange(5, 9);

                    notificationTextBox.Text = "";

                    foreach (var item in notifications)
                    {
                        notificationTextBox.Text += item + "\r\n\r\n";
                    }
                }

                notificationTextBox.Text += message + "\r\n\r\n";
            });
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // закрываем все задачи

            painter.Stop();

            foreach (var item in competitions)
            {
                item.IsCanceled = true;
            }

            foreach (var item in viewModels)
            {
                if (item is ViewModel viewModel)
                    viewModel.Model.IsCanceled = true;
            }
        }

        void InputPersonModel(PersonModel personModel)
        {
            // input firstName, lastName

            InputStringDialog inputLastName = new InputStringDialog(new WordValidator(), "Введите Фамилию");

            if (inputLastName.ShowDialog() == DialogResult.OK)
            {
                personModel.LastName = inputLastName.Value;
            }

            InputStringDialog inputFirstName = new InputStringDialog(new WordValidator(), "Введите Имя");

            if (inputFirstName.ShowDialog() == DialogResult.OK)
            {
                personModel.FirstName = inputFirstName.Value;
            }
        }

        private void addSportsmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sportsman newSportsman = new Sportsman(Notification, gym.X, gym.Y);

            InputPersonModel(newSportsman);

            // add to list and add to view

            lock(sportsmansLocker)
            {
                sportsmans.Add(newSportsman);
            }

            lock(viewModels)
            {
                viewModels.Add(new ViewModel(newSportsman, sportsmanImage));
            }

            // запустим спросмена
            Task.Run(newSportsman.Start);
        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type doctorType = typeof(Cardiologist);

            SelectDoctorType selectDoctorType = new SelectDoctorType(doctorTypes);

            if (selectDoctorType.ShowDialog() == DialogResult.OK)
            {
                doctorType = selectDoctorType.SelectedType;
            }

            Doctor doctor = Activator.CreateInstance(doctorType,
                new object[] { (Action<string>)Notification, hospital.X, hospital.Y, sportsmans, sportsmansLocker }) as Doctor;

            InputPersonModel(doctor);

            lock (viewModelsLocker)
            {
                viewModels.Add(new ViewModel(doctor, doctorImage));
            }

            Task.Run(doctor.Start);
        }

        void SetBuildingsSize()
        {
            // задём центры зданий в завимости от размеров pictureBox и картинок

            // больница будет в левом верхнем углу
            hospital.X = pictureBox.Width - hospitalImage.Width / 2;
            hospital.Y = hospitalImage.Height / 2;

            // тренажёрный зал будет в правом нижнем углу

            gym.X = pictureBox.Width - gymImage.Width / 2;
            gym.Y = pictureBox.Height - gymImage.Height / 2;
        }

        void AddCompetition(string competitionName, int maxParticipatingSportmansNumber = 5)
        {
            float x = stadiumImage.Width / 2,
                y = stadiumImage.Height / 2;

            y += competitions.Count() * stadiumImage.Height;

            competitions.Add(new Competition(Notification, sportsmans, sportsmansLocker, x, y, competitionName, maxParticipatingSportmansNumber));

            lock (viewObjectsLocker)
            {
                viewObjects.Add(new ViewObject(stadiumImage, x, y));
            }

            Task.Run(competitions[competitions.Count() - 1].Start);

            if (competitions.Count() >= maxCompetitionsNumber)
                addCompatitionToolStripMenuItem.Enabled = false;
        }

        void GenerateSportmans(int sportmansNumber)
        {
            // создадим несколько спорстменов, врачей, соревнование, запустим их в потоках

            for (int i = 0; i < sportmansNumber; i++)
            {
                var newSportsman = new Sportsman(Notification, gym.X, gym.Y)
                {
                    LastName = "SpLast" + i.ToString(),
                    FirstName = "SpFirst" + i.ToString()
                };

                sportsmans.Add(newSportsman);

                viewModels.Add(new ViewModel(newSportsman, sportsmanImage));

                Task.Run(newSportsman.Start);
            }
        }

        void GenerateDoctors(int doctorsNumber)
        {
            object[] doctorArgs = new object[]
           { (Action<string>)Notification,
                hospital.X,
                hospital.Y,
                sportsmans,
                sportsmansLocker };

            for (int i = 0; i < doctorsNumber; i++)
            {
                foreach (var item in doctorTypes)
                {
                    Doctor newDoctor = Activator.CreateInstance(item, doctorArgs) as Doctor;
                    newDoctor.LastName = "DtLast" + i.ToString();
                    newDoctor.FirstName = "DtFirst" + i.ToString();

                    viewModels.Add(new ViewModel(newDoctor, doctorImage));

                    Task.Run(newDoctor.Start);
                }
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSportsmanToolStripMenuItem.Enabled = true;
            addDoctorToolStripMenuItem.Enabled = true;
            startToolStripMenuItem.Enabled = false;
            addCompatitionToolStripMenuItem.Enabled = true;

            painter = new Painter(pictureBox, Color.FromArgb(128, 255, 128),
               new Font(notificationTextBox.Font.FontFamily, 10f, notificationTextBox.Font.Style),
               viewObjects, viewObjectsLocker, viewModels, viewModelsLocker);

            // create buildings

            hospital = new ViewObject(hospitalImage);
            gym = new ViewObject(gymImage);

            SetBuildingsSize();

            // add hospital, stadium, gym
            viewObjects.Add(hospital);
            viewObjects.Add(gym);

            AddCompetition("Соревнование 1");

            GenerateSportmans(8);

            GenerateDoctors(1);

            painter.Start();
        }

        private void addCompatitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputStringDialog inputCompettionName = new InputStringDialog(new WordValidator(), "Введите имя соревнования");

            string name = "";

            if (inputCompettionName.ShowDialog() == DialogResult.OK)
                name = inputCompettionName.Value;

            InputStringDialog inputMaxParticipatingSportmansNumber = new InputStringDialog(new NotNegativeIntValidator(),
                "Введите максимальное количество спортсменов на соревновании");

            if (inputMaxParticipatingSportmansNumber.ShowDialog() == DialogResult.OK)
                AddCompetition(name, Int32.Parse(inputMaxParticipatingSportmansNumber.Value));
            else
                AddCompetition(name);
        }
    }
}
