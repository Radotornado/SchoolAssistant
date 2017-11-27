namespace SchoolAssistant
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class TeacherForm : Form
    {
        private static TeacherChosen teacherChosen = new TeacherChosen();
        private static Time timeNow = new Time();
        private Timer t = new Timer();
        string[] Teacherlines = System.IO.File.ReadAllLines(@"teacherPageIDs.txt");
        public string programPath = "";
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            teacherChosen = Main.teacherChosen;
            timeNow = Main.timeNow;
            label1.Text = teacherChosen.Names;
            label2.Text = teacherChosen.Special;
            label4.Text += teacherChosen.Subject;
            label3.Text += teacherChosen.Consultation;
            label3.MaximumSize = new Size(300, 0);
            label3.AutoSize = true;
            if (teacherChosen.sip == "")
            {
                label7.Text = "Няма въведен СИП";
            }
            else
            {
                label7.Text += teacherChosen.sip;
                label7.MaximumSize = new Size(300, 0);
                label7.AutoSize = true;
            }
            string[] lines = System.IO.File.ReadAllLines(@"NewProgramsTeachersFilePath.txt");
            try
            {
                programPath = lines[0];
            }
            catch (IndexOutOfRangeException ex)
            {
                programPath = "";
            }
            int page = 0;

            // TODO make this work 
            //for (int i = 1; i <= Teacherlines.Length; i+=2)
            //{
            //    int a = i;
            //    a--;
            //    if (teacherChosen.Names == Teacherlines[i])
            //    {
            //        page = int.Parse(Teacherlines[i]);
            //    }
            //}

            switch (teacherChosen.Names) // Very very ugly 
            { 
                #region Checking for teachers and assigning in table
                case "Ирена Желязкова": page = 1; break;
                case "Веселина Симеонова": page = 60; break;
                case "Евгения Узункирова": page = 15; break;
                case "Златина Байнашева": page = 31; break;
                case "Иванка Динева": page = 66; break;
                case "Мариана Милева": page = 65; break;
                case "Анелия Диновска": page = 17; break;
                case "Бонка Накова": page = 22; break;
                case "Бранимира Цонева": page = 25; break;
                case "Галина Перфанова": page = 12; break;
                case "Евгений Рандев": page = 18; break;
                case "Елисавета Коларова": page = 23; break;
                case "Жанета Желязкова": page = 64; break;
                case "Ивелина Стойкова": page = 19; break;
                case "Ирена Йорданова": page = 16; break;
                case "Марияна Бонева": page = 21; break;
                case "Нина Йовчева": page = 20; break;
                case "Татяна Качарова": page = 26; break;
                case "Мария Станкова": page = 24; break;
                case "Цветелина Димитрова": page = 29; break;
                case "Елена Ангелова": page = 28; break;
                case "Ваня Няголова": page = 34; break;
                case "Венета Кирова": page = 32; break;
                case "Донка Койчева": page = 38; break;
                case "Маргарита Турсунлийска": page = 35; break;
                case "Минка Въжарова": page = 13; break;
                case "Румен Иванов": page = 5; break;
                case "Светлана Терзиева": page = 51; break;
                case "Таня Димитрова": page = 37; break;
                case "Тянка Кесова": page = 33; break;
                case "Виолета Балтова": page = 41; break;
                case "Екатерина Господинова": page = 42; break;
                case "Екатерина Найденова": page = 46; break;
                case "Недялка Рандева": page = 44; break;
                case "Павлина Дончева": page = 61; break;
                case "Пепа Пенчева": page = 39; break;
                case "Стефка Петкова": page = 40; break;
                case "Таня Стоянова": page = 47; break;
                case "Христина Ангелова": page = 36; break;
                case "Лилия Аджемова": page = 4; break;
                case "Таня Еленска": page = 6; break;
                case "Цветалина Топракчиева": page = 27; break;
                case "Димитринка Дюлгерова": page = 7; break;
                case "Милена Илиева": page = 8; break;
                case "Милена Чолакова": page = 49; break;
                case "Георги Стоилов": page = 48; break;
                case "Ива Пенчева": page = 63; break;
                case "Стефка Генчева": page = 43; break;
                case "Ганка Берковска": page = 52; break;
                case "Людмила Йорданова": page = 53; break;
                case "Поля Филипова": page = 50; break;
                case "Росица Делчева": page = 45; break;
                case "Росица Монева": page = 9; break;
                case "Кета Андреева": page = 54; break;
                case "Стойка Йорданова": page = 11; break;
                case "Женя Кожева": page = 55; break;
                case "Лидия Димитрова": page = 57; break;
                case "Станислав Димитров": page = 56; break;
                case "Елена Стоилова": page = 68; break;
                case "Димитринка Дойчинова": page = 58; break;
                case "Йоан Попов": page = 30; break;
                case "Божидар Кралев":  page = 3; break;
                case "Красимира Иванова": page = 14; break;
                case "Кристина Василева": page = 62; break;
                case "Николай Бъчваров": page = 67; break;
                case "Панайот Авджиев": page = 59; break;
                case "Цветан Русинов": page = 10; break;
                default: page = 0; break;
                    #endregion
            }
            if (page == 0)
            {
                MessageBox.Show("Учителят няма програма!");
            }
            else
            {
                if (programPath!= "")
                {
                    webBrowser1.Navigate($@"{programPath}#page={page}"); // gets the path to the new file
                }
                else
                {
                    string currentDirectory = System.IO.Directory.GetCurrentDirectory(); // gets the current directory. Nessesary due to installer
                    webBrowser1.Navigate(currentDirectory + "\\" + $"teachers.pdf#page={page}"); 
                }
            }
            
            if (timeNow.dateInClass != "")  label5.Text = timeNow.dateInClass;
            else label5.Text = timeNow.dateNoClass; 
            t.Enabled = true; // make a timer
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = "";
            if (hh < 10) time += "0" + hh;
            else time += hh;
            time += ":";
            if (mm < 10) time += "0" + mm;
            else time += mm;
            time += ":";
            if (ss < 10) time += "0" + ss;
            else time += ss;
            label6.Text = "Сега е " + time + " часът."; // shows current time
        }
    }

    
}
