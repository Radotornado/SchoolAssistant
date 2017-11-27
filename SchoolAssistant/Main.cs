namespace SchoolAssistant
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;
    using System.Windows.Forms;


    public partial class Main : Form
    {
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Teachers.accdb"); // Include DB
        public static TeacherChosen teacherChosen = new TeacherChosen();
        public static AllTeachers Allteachers = new AllTeachers();
        public static Classes classes = new Classes();
        public static string classChosen = "";
        private int classTime = 0;
        private string shift = "";
        private string dayOfWeekInBG = "";
        private TimeSpan[] TimeSpansForClasses = new TimeSpan[28];
        public static Time timeNow = new Time();
        public static Main Form;
        private TimeSpan now = DateTime.Now.TimeOfDay;
        private Timer t = new Timer();
        private int[] hours = { 7, 8, 8, 9, 9, 9, 10, 10, 11, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16, 16, 17, 17, 17, 18, 18, 19 };
        private int[] minutes = { 30, 10, 20, 0, 10, 50, 10, 50, 0, 40, 50, 30, 40, 20, 30, 10, 20, 0, 20, 0, 10, 50, 0, 40, 50, 30, 40, 20 };
        private string pathTeachers = @"NewProgramsTeachersFilePath.txt";
        private string pathClasses = @"NewProgramsClassesFilePath.txt";

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacherChosen.Names = comboBox1.SelectedItem.ToString(); // Find and bind the chosen teacher from combo box

            for (int i = 0; i < Allteachers.Names.Count; i++)
            {
                if (teacherChosen.Names.Equals(Allteachers.Names[i]) == true)
                {
                    teacherChosen.Names = Allteachers.Names[i];
                    teacherChosen.Subject = Allteachers.Subject[i];
                    teacherChosen.Special = Allteachers.Special[i];
                    teacherChosen.Consultation = Allteachers.Consultation[i];
                    teacherChosen.sip = Allteachers.sip[i];
                }
            }

            TeacherForm teacherForm = new TeacherForm(); // open TeacherForm
            teacherForm.Show();
        }

        public List<string> getTeacherInfo() // gets the info form DB in tables Teachers and Subjects
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM Teachers INNER JOIN Subject ON Subject.ID = Teachers.Subject_ID ORDER BY Teachers.Name ASC", connection);
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter(com);
            ad.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Allteachers.Names.Add(dr["Name"].ToString());
                Allteachers.Subject.Add(dr["SubjName"].ToString());
                if (dr["Special"] != null)
                {
                    Allteachers.Special.Add(dr["Special"].ToString());
                }
                Allteachers.Consultation.Add(dr["Consultation"].ToString());
                if (dr["SIP"] != null)
                {
                    Allteachers.sip.Add(dr["SIP"].ToString());
                }
            }
            connection.Close();
            return Allteachers.Names;
        }

        public List<string> getClassInfo() // gets the name and the class teacher form DB in table Classes 
        {
            OleDbCommand com = new OleDbCommand("SELECT ClassNames, Teacher FROM Classes", connection);
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter(com);
            ad.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                classes.className.Add(dr["ClassNames"].ToString());
                classes.classTeacher.Add(dr["Teacher"].ToString());
            }
            connection.Close();
            return classes.className;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = getTeacherInfo(); 
            comboBox2.DataSource = getClassInfo();
            t.Enabled = true; // make a timer, set the interval to 1sek and start it for the current time
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            classChosen = comboBox2.Text; // bind the chosen class to pass it to Class form
            Class classForm = new Class();
            classForm.Show();
        }

        public void dateTimeInfo()
        {
            int hh = DateTime.Now.Hour; // make a clock
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
            label5.Text = "Сега е " + time + " часът.";

            for (int i = 0; i < hours.Length; i++) // get the times form arrays and convert them to TimeSpan
            {
                TimeSpansForClasses[i] = new TimeSpan(hours[i], minutes[i], 0);
            }
            int f = 1; // Check for current class time and shift
            int s = 1; 
            for (int i = 1; i < 14; i+=2)
            {
                int a = i;
                a--;
                if ((now > TimeSpansForClasses[a]) && (now < TimeSpansForClasses[i]))
                {
                    classTime = f;
                    shift = "първа";
                }
                f++;
            }
            for (int i = 15; i < 28; i += 2)
            {
                int a = i;
                a--;
                if ((now > TimeSpansForClasses[a]) && (now < TimeSpansForClasses[i]))
                {
                    classTime = s;
                    shift = "втора";
                }
                s++;
            }
            


            switch (DateTime.Now.DayOfWeek.ToString())
            {
                #region Turn days of week to BG
                case "Monday": dayOfWeekInBG = "Понеделник"; break;
                case "Tuesday": dayOfWeekInBG = "Вторник"; break;
                case "Wednesday": dayOfWeekInBG = "Сряда"; break;
                case "Thursday": dayOfWeekInBG = "Четвъртък"; break;
                case "Friday": dayOfWeekInBG = "Петък"; break;
                case "Saturday": dayOfWeekInBG = "Събота"; break;
                case "Sunday": dayOfWeekInBG = "Неделя"; break;
                #endregion
            }
            if (classTime != 0 && shift != "") // sets the string for class time and shift
            {
                if (dayOfWeekInBG == "Събота" || dayOfWeekInBG == "Неделя")
                {
                    timeNow.dateNoClass = $"Неучебен ден. Днес е  {dayOfWeekInBG} - {DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}г.";
                }
                else
                {
                    timeNow.dateInClass = $"Сега е {classTime} час от  {shift} смяна. Днес е {dayOfWeekInBG} - {DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}г.";
                }
            }
            else
            {
                timeNow.dateNoClass = $"Часът не е започнал. Днес е  {dayOfWeekInBG} - {DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}г.";
            }
            if (classTime != 0) // sets the label for current class time and shift
            {
                label6.Text = timeNow.dateInClass;
            }
            else
            {
                label6.Text = timeNow.dateNoClass;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimeInfo(); // every second call the time
        }
        

        private void directorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Director directorForm = new Director();
            directorForm.Show();
        }

        private void assisDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssisDirector assisDirectorForm = new AssisDirector();
            assisDirectorForm.Show();
        }

        private void ShiftRegimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShiftRegime shiftRegimeForm = new ShiftRegime();
            shiftRegimeForm.Show();
        }

        private void yourClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YourClass yourClassForm = new YourClass();
            yourClassForm.Show();
        }

        private void infoPmgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoPMG infoPMGFOrm = new infoPMG();
            infoPMGFOrm.Show();
        }

        private void infoProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoProject infoProjectForm = new infoProject();
            infoProjectForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElBell elbellForm = new ElBell();
            elbellForm.Show();
        }

        private void mainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void elBellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void changesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void addRemoveTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRemoveTeacher addRemoveTeacherForm = new AddRemoveTeacher();
            addRemoveTeacherForm.Show();
        }

        private void AddRemoveSipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeAddSip ChangeAddSipForm = new ChangeAddSip();
            ChangeAddSipForm.Show();
        }

        private void changeConsultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeConsultation ChangeConsultationForm = new ChangeConsultation();
            ChangeConsultationForm.Show();
        }
        

        private void changFileProgramsTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
            }

            if (MessageBox.Show("Сигурни ли сте? Старият файл ще се замени. При натискане на \"No\" ще се зададе файлът по подразбиране.", "Нужно е потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.WriteAllText(pathTeachers, String.Empty); // saves the new asked directory in text file
                using (FileStream fs = new FileStream(pathTeachers, FileMode.OpenOrCreate))
                {
                    using (TextWriter tw = new StreamWriter(fs))
                    {
                        tw.WriteLine(openFileDialog1.FileName);
                    }
                }
            }
            else
            {
                File.WriteAllText(pathTeachers, String.Empty);
            }
        }

        private void changeFileProgramsClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
            }

            if (MessageBox.Show("Сигурни ли сте? Старият файл ще се замени. При натискане на \"No\" ще се зададе файлът по подразбиране.", "Нужно е потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.WriteAllText(pathClasses, String.Empty);
                using (FileStream fs = new FileStream(pathClasses, FileMode.OpenOrCreate))
                {
                    using (TextWriter tw = new StreamWriter(fs))
                    {
                        tw.WriteLine(openFileDialog1.FileName);
                    }
                }
            }
            else
            {
                File.WriteAllText(pathClasses, String.Empty);
            }
        }
    }
    public class AllTeachers // classes for passing variables from one form to other
    {
        public List<string> Names = new List<string>();
        public List<string> Subject = new List<string>();
        public List<string> Special = new List<string>();
        public List<string> Consultation = new List<string>();
        public List<string> sip = new List<string>();
    }
    public class TeacherChosen
    {
        public string Names;
        public string Subject;
        public string Special;
        public string Consultation;
        public string sip;
    }

    public class Time
    {
        public string dateInClass = "";
        public string dateNoClass = "";
    }

    public class Classes
    {
        public List<string> className = new List<string>();
        public List<string> classTeacher = new List<string>();
    }
}
