namespace SchoolAssistant
{

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO.Ports;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public static TeacherChosen teacherChosen = new TeacherChosen();
        public static AllTeachers Allteachers = new AllTeachers();
        public static YourClass yourClassInfo = new YourClass();
        public static string classChosen = "";
        private TimeSpan[] TimeSpansForClasses = new TimeSpan[28];
        public static Time timeNow = new Time();
        private TimeSpan now = DateTime.Now.TimeOfDay;
        private Timer t = new Timer();
        private int[] hours = { 7, 8, 8, 9, 9, 9, 10, 10, 11, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16, 16, 17, 17, 17, 18, 18, 19 };
        private int[] minutes = { 30, 10, 20, 0, 10, 50, 10, 50, 0, 40, 50, 30, 40, 20, 30, 10, 20, 0, 20, 0, 10, 50, 0, 40, 50, 30, 40, 20 };
        private string classShiftDateLabelText = "";
        private bool isHelpButtonPressed, isInfoButtonPressed, isChangesButtonPressed = false;
        private int[] animValues = { 254, 292, 330, 216, 252, 292, 326, 356, 390, 426, 178, 216, 256, 292, 330, 368 };


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Height = 598;

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            contentsPanel.Controls.Add(TeachersUC.Instance);
            TeachersUC.Instance.Dock = DockStyle.Fill;
            TeachersUC.Instance.BringToFront();

            t.Enabled = true; // make a timer, set the interval to 1sek and start it for the current time
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer_Tick);
            t.Start();

            helpButton.TextImageRelation = TextImageRelation.ImageBeforeText;

            hideAllDropdownMenuButtons();

        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mimiseLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topRightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void topRightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void topRightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void classesButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(ClassesUC.Instance);
            ClassesUC.Instance.Dock = DockStyle.Fill;
            ClassesUC.Instance.BringToFront();
        }

        private void elBellButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(ElBellUC.Instance);
            ElBellUC.Instance.Dock = DockStyle.Fill;
            ElBellUC.Instance.BringToFront();
            if (SerialPort.GetPortNames().Length == 0)
            {
                Point p1 = new Point();
                p1.X = 15;
                p1.Y = 545;
                Point scrPos = this.PointToScreen(p1);
                notificationForm childForm = new notificationForm("Няма включен електронен звънец!", notificationForm.AlertType.noElBells, scrPos, 324);
                childForm.Show();
            }
        }



        private void timer_Tick(object sender, EventArgs e)
        {
            Methods methods = new Methods();
            clockLabel.Text = "Сега е " + DateTime.Now.ToString("HH:mm:ss") + " часът.";
            classShiftDateLabel.Text = methods.getShiftClassLabel(classShiftDateLabelText);
        }

        private void teachersButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(TeachersUC.Instance);
            TeachersUC.Instance.Dock = DockStyle.Fill;
            TeachersUC.Instance.BringToFront();
        }
        private void infoButton_Click(object sender, EventArgs e)
        {
            resetButtonPlacement();
            isInfoButtonPressed = true;
            if (isHelpButtonPressed == true)
            {
                upTimerHelpButton.Start();
                isHelpButtonPressed = false;
            }
            else if (isChangesButtonPressed == true)
            {
                upTimerChangesButton.Start();
                isChangesButtonPressed = false;
            }
            if (directorInfoDropdownButton.Visible != true)
            {
                dropdownTimerInfoButton.Start();
            }
            else
            {
                upTimerInfoButton.Start();
                isInfoButtonPressed = false;
            }

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            resetButtonPlacement();
            isHelpButtonPressed = true;
            if (isInfoButtonPressed == true)
            {
                upTimerInfoButton.Start();
                isInfoButtonPressed = false;
            }
            else if (isChangesButtonPressed == true)
            {
                upTimerChangesButton.Start();
                isChangesButtonPressed = false;
            }
            if (teacherClassesDropdownHelpButton.Visible != true)
            {
                dropdownTimerHelpButton.Start();
            }
            else
            {
                upTimerHelpButton.Start();
                isHelpButtonPressed = false;
            }

        }

        private void changesButton_Click(object sender, EventArgs e)
        {
            resetButtonPlacement();
            isChangesButtonPressed = true;
            if (isInfoButtonPressed == true)
            {
                upTimerInfoButton.Start();
                isInfoButtonPressed = false;
            }
            else if (isHelpButtonPressed == true)
            {
                upTimerHelpButton.Start();
                isHelpButtonPressed = false;
            }
            if (teacherChangesDropdownButton.Visible != true)
            {
                dropdownTimerChangesButon.Start();
            }
            else
            {
                upTimerChangesButton.Start();
                isChangesButtonPressed = false;
            }
        }



        private void helpButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            helpButton.ForeColor = Color.FromArgb(229, 126, 49);


        }

        private void helpButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            helpButton.ForeColor = Color.LightGray;


        }


        private void infoButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            infoButton.ForeColor = Color.LightGray;
        }

        private void infoButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            infoButton.ForeColor = Color.FromArgb(229, 126, 49);

        }

        private void changesButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            changesButton.ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void changesButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            changesButton.ForeColor = Color.LightGray;

        }

        private void elBellButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            elBellButton.ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void elBellButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            elBellButton.ForeColor = Color.LightGray;
        }

        private void classesButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            classesButton.ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void classesButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            classesButton.ForeColor = Color.LightGray;
        }

        private void teachersButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            teachersButton.ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void teachersButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            teachersButton.ForeColor = Color.LightGray;
        }

        private void dropdownTimerHelpButton_Tick(object sender, EventArgs e)
        {

            helpButton.Image = Image.FromFile(@"Images\upArrow.png");

            if (animValues[0] < 290)
            {
                teacherClassesDropdownHelpButton.Top = animValues[0] += 6;
                teacherClassesDropdownHelpButton.Visible = true;
            }
            else if (animValues[1] < 328)
            {
                elBellDropdownHelpButton.Top = animValues[1] += 6;
                elBellDropdownHelpButton.Visible = true;
            }
            else if (animValues[2] < 366)
            {
                changesDropdownHelpButton.Top = animValues[2] += 6;
                changesDropdownHelpButton.Visible = true;
            }
            else
            {
                dropdownTimerHelpButton.Stop();
                animValues[0] = 254;
                animValues[1] = 292;
                animValues[2] = 330;
            }
        }

        private void upTimerHelpButton_Tick(object sender, EventArgs e)
        {
            teacherClassesDropdownHelpButton.Visible = false;
            elBellDropdownHelpButton.Visible = false;
            changesDropdownHelpButton.Visible = false;
            helpButton.Image = Image.FromFile(@"Images\downArrow.png");
            animValues[0] = 254;
            animValues[1] = 292;
            animValues[2] = 330;
            resetButtonPlacement();
            upTimerHelpButton.Stop();
        }
        private void dropdownTimerInfoButton_Tick(object sender, EventArgs e)
        {
            infoButton.Image = Image.FromFile(@"Images\upArrow.png");
            helpButton.Visible = false;
            if (animValues[3] < 252)
            {
                directorInfoDropdownButton.Visible = true;
                directorInfoDropdownButton.Top = animValues[3] += 6;
            }
            else if (animValues[4] < 288)
            {
                zamDirectorInfoDropdownButton.Visible = true;
                zamDirectorInfoDropdownButton.Top = animValues[4] += 6;
            }
            else if (animValues[5] < 322)
            {
                shiftRegimeInfoDropdownButton.Visible = true;
                shiftRegimeInfoDropdownButton.Top = animValues[5] += 6;
            }
            else if (animValues[6] < 356)
            {
                yourClassInfoDropdownButton.Visible = true;
                yourClassInfoDropdownButton.Top = animValues[6] += 6;
            }
            else if (animValues[7] < 390)
            {
                gimnasiumInfoDropdownButton.Visible = true;
                gimnasiumInfoDropdownButton.Top = animValues[7] += 6;
            }
            else if (animValues[8] < 426)
            {
                schoolAssistantInfoDropdownButton.Visible = true;
                schoolAssistantInfoDropdownButton.Top = animValues[8] += 6;
            }
            else if (animValues[9] < 460)
            {
                helpButton.Visible = true;
                helpButton.Top = animValues[9] += 6;
            }
            else
            {
                helpButton.Visible = true;
                dropdownTimerInfoButton.Stop();
                animValues[3] = 216;
                animValues[4] = 252;
                animValues[5] = 292;
                animValues[6] = 326;
                animValues[7] = 356;
                animValues[8] = 390;
                animValues[9] = 426;
            }
        }

        private void upTimerInfoButton_Tick(object sender, EventArgs e)
        {
            directorInfoDropdownButton.Visible = false;
            zamDirectorInfoDropdownButton.Visible = false;
            shiftRegimeInfoDropdownButton.Visible = false;
            yourClassInfoDropdownButton.Visible = false;
            gimnasiumInfoDropdownButton.Visible = false;
            schoolAssistantInfoDropdownButton.Visible = false;
            infoButton.Image = Image.FromFile(@"Images\downArrow.png");
            if (helpButton.Top >= 254)
            {
                helpButton.Top -= 6;
            }
            else
            {
                animValues[3] = 216;
                animValues[4] = 252;
                animValues[5] = 292;
                animValues[6] = 326;
                animValues[7] = 356;
                animValues[8] = 390;
                animValues[9] = 426;
                resetButtonPlacement();
                upTimerInfoButton.Stop();
            }
        } 
        private void dropdownTimerChangesButon_Tick(object sender, EventArgs e)
        {
            changesButton.Image = Image.FromFile(@"Images\upArrow.png");
            if (animValues[10] < 214)
            {
                teacherChangesDropdownButton.Visible = true;
                teacherChangesDropdownButton.Top = animValues[10] += 6;
            }
            else if (animValues[11] < 250)
            {
                sipChangesDropdownButton.Visible = true;
                sipChangesDropdownButton.Top = animValues[11] += 6;
            }
            else if (animValues[12] < 286)
            {
                consultationChangesDropdownButton.Visible = true;
                consultationChangesDropdownButton.Top = animValues[12] += 6;
            }
            else if (animValues[13] < 320)
            {
                classTeacherChangesDropdownButton.Visible = true;
                classTeacherChangesDropdownButton.Top = animValues[13] += 6;
            }
            else if (animValues[14] < 358)
            {
                infoButton.Visible = true;
                infoButton.Top = animValues[14] += 6;
            }
            else if (animValues[15] < 388)
            {
                helpButton.Visible = true;
                helpButton.Top = animValues[15] += 6;
            }
            else
            {
                dropdownTimerChangesButon.Stop();
                animValues[10] = 178;
                animValues[11] = 216;
                animValues[12] = 256;
                animValues[13] = 292;
                animValues[14] = 330;
                animValues[15] = 368;
            }

            }

        private void upTimerChangesButton_Tick(object sender, EventArgs e)
        {
            changesButton.Image = Image.FromFile(@"Images\DownArrow.png");
            teacherChangesDropdownButton.Visible = false;
            sipChangesDropdownButton.Visible = false;
            consultationChangesDropdownButton.Visible = false;
            classTeacherChangesDropdownButton.Visible = false;

            if (animValues[15] > 254)
            {
                helpButton.Top = animValues[15] -= 5;
                infoButton.Top = animValues[14] -= 5;
                infoButton.BringToFront();
            }
            else
            {
                animValues[14] = 330;
                animValues[15] = 368;
                resetButtonPlacement();
                upTimerChangesButton.Stop();
            }
        }



        private void teacherClassesDropdownHelpButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(TeacherClassesHelpUC.Instance);
            TeacherClassesHelpUC.Instance.Dock = DockStyle.Fill;
            TeacherClassesHelpUC.Instance.BringToFront();
        }

        private void teacherChangesDropdownButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(TeacherChangesUC.Instance);
            TeacherChangesUC.Instance.Dock = DockStyle.Fill;
            TeacherChangesUC.Instance.BringToFront();
        }

        private void consultationChangesDropdownButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(ConsultationChangesUC.Instance);
            ConsultationChangesUC.Instance.Dock = DockStyle.Fill;
            ConsultationChangesUC.Instance.BringToFront();
        }

        private void sipChangesDropdownButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(SipChangesUC.Instance);
            SipChangesUC.Instance.Dock = DockStyle.Fill;
            SipChangesUC.Instance.BringToFront();
        }

        private void directorInfoDropdownButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(DirectorInfoUC.Instance);
            DirectorInfoUC.Instance.Dock = DockStyle.Fill;
            DirectorInfoUC.Instance.BringToFront();
        }

        private void zamDirectorInfoDropdownButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(DeputyDirectorInfoUC.Instance);
            DeputyDirectorInfoUC.Instance.Dock = DockStyle.Fill;
            DeputyDirectorInfoUC.Instance.BringToFront();
        }

        private void shiftRegimeInfoDropdownButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(ShiftRegimeInfoUC.Instance);
            ShiftRegimeInfoUC.Instance.Dock = DockStyle.Fill;
            ShiftRegimeInfoUC.Instance.BringToFront();
        }

        private void yourClassInfoDropdownButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(YourClassInfoUC.Instance);
            YourClassInfoUC.Instance.Dock = DockStyle.Fill;
            YourClassInfoUC.Instance.BringToFront();
        }

        private void gimnasiumInfoDropdownButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(SchoolInfoUC.Instance);
            SchoolInfoUC.Instance.Dock = DockStyle.Fill;
            SchoolInfoUC.Instance.BringToFront();
        }

        private void schoolAssistantInfoDropdownButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(SchoolAssistantInfoUC.Instance);
            SchoolAssistantInfoUC.Instance.Dock = DockStyle.Fill;
            SchoolAssistantInfoUC.Instance.BringToFront();
        }

        private void classTeacherChangesDropdownButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(ClassTeacherChangeUC.Instance);
            ClassTeacherChangeUC.Instance.Dock = DockStyle.Fill;
            ClassTeacherChangeUC.Instance.BringToFront();
        }

        private void elBellDropdownHelpButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(ElBellHelpUC.Instance);
            ElBellHelpUC.Instance.Dock = DockStyle.Fill;
            ElBellHelpUC.Instance.BringToFront();
        }

        private void changesDropdownHelpButton_Click(object sender, EventArgs e)
        {
            contentsPanel.Controls.Add(ChangesHelpUC.Instance);
            ChangesHelpUC.Instance.Dock = DockStyle.Fill;
            ChangesHelpUC.Instance.BringToFront();
        }

        private void hideAllDropdownMenuButtons()
        {
            teacherClassesDropdownHelpButton.Visible = false;
            elBellDropdownHelpButton.Visible = false;
            changesDropdownHelpButton.Visible = false;

            directorInfoDropdownButton.Visible = false;
            zamDirectorInfoDropdownButton.Visible = false;
            shiftRegimeInfoDropdownButton.Visible = false;
            yourClassInfoDropdownButton.Visible = false;
            gimnasiumInfoDropdownButton.Visible = false;
            schoolAssistantInfoDropdownButton.Visible = false;

            teacherChangesDropdownButton.Visible = false;
            sipChangesDropdownButton.Visible = false;
            consultationChangesDropdownButton.Visible = false;
            classTeacherChangesDropdownButton.Visible = false;
        }

        private void resetButtonPlacement()
        {
            changesButton.Top = 178;
            infoButton.Top = 216;
            helpButton.Top = 254;
        }
    }
    public class AllTeachers // classes for passing variables from one form to other
    {
        public List<string> Names = new List<string>();
        public List<string> Subject = new List<string>();
        public List<string> Special = new List<string>();
        public List<string> Consultation = new List<string>();
        public List<string> Sip = new List<string>();
        public List<int> Page = new List<int>();
    }
    public class TeacherChosen
    {
        public string Names;
        public string Subject;
        public string Special;
        public string Consultation;
        public string Sip;
        public int Page;
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
        public List<int> page = new List<int>();
    }

    public class YourClass
    {
        public List<string> Groups = new List<string>();
        public List<string> Teachers = new List<string>();
    }
}
