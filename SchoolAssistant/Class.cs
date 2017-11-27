namespace SchoolAssistant
{
    using System;
    using System.Windows.Forms;

    public partial class Class : Form
    {
        private static Classes classes = new Classes();
        private string classChosen = "";
        private static Time timeNow = new Time();
        private Timer t = new Timer();
        public string programPath = "";
        public Class()
        {
            InitializeComponent();
            classChosen = Main.classChosen;
            timeNow = Main.timeNow;
            classes = Main.classes;
        }

        private void Class_Load(object sender, EventArgs e)
        {
            int page = 0;
            string[] lines = System.IO.File.ReadAllLines(@"NewProgramsClassesFilePath.txt");
            try
            {
                programPath = lines[0];
            }
            catch (IndexOutOfRangeException ex)
            {
                programPath = "";
            }
            for (int i = 0; i < classes.className.Count; i++)
            {
                page++;
                if (classes.className[i] == classChosen)
                {
                    if (page == 0)
                    {
                        MessageBox.Show("класът няма програма!");
                    }
                    else
                    {
                        if (programPath != "")
                        {
                            webBrowser1.Navigate($@"{programPath}#page={page}");
                        }
                        else
                        {
                            string currentDirectory = System.IO.Directory.GetCurrentDirectory();
                            webBrowser1.Navigate(currentDirectory + "\\" + $"classes.pdf#page={page}");
                        }
                    }
                    label1.Text = "Класен ръководител: " + classes.classTeacher[--page];
                }
            }
            
            label2.Text = classChosen + " Клас";
            if (timeNow.dateInClass != "") label3.Text = timeNow.dateInClass;
            else label3.Text = timeNow.dateNoClass;
            t.Enabled = true;
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
            label4.Text = "Сега е " + time + " часът.";
        }
    }
}
