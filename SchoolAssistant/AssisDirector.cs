namespace SchoolAssistant
{
    using System;
    using System.Windows.Forms;

    public partial class AssisDirector : Form
    {
        private static Time timeNow = new Time();
        private Timer t = new Timer();
        public AssisDirector()
        {
            InitializeComponent();
            timeNow = Main.timeNow;
        }

        private void AssisDirector_Load(object sender, EventArgs e)
        {
            string currentDirectory = System.IO.Directory.GetCurrentDirectory();
            webBrowser1.Navigate(currentDirectory + "\\" + $"teachers.pdf#page=52");
            webBrowser2.Navigate(currentDirectory + "\\" + $"teachers.pdf#page=28");
            if (timeNow.dateInClass != "") label6.Text = timeNow.dateInClass;
            else label6.Text = timeNow.dateNoClass;
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
            label5.Text = "Сега е " + time + " часът.";
        }
    }
}
