namespace SchoolAssistant
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class DeputyDirectorInfoUC : UserControl
    {
        private static DeputyDirectorInfoUC _instance;
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Resources\Teachers.accdb"); // Include DB
        public static TeacherChosen teacherChosen = new TeacherChosen();
        private static AllTeachers Allteachers = new AllTeachers();
        private string[] Teacherlines = System.IO.File.ReadAllLines(@"Resources\teacherPageIDs.txt");
        public string programPath = "";
        public static DeputyDirectorInfoUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DeputyDirectorInfoUC();
                return _instance;
            }
            set { }
        }
        public DeputyDirectorInfoUC()
        {
            InitializeComponent();

            teacherChosen = MainForm.teacherChosen;

            string[] teacherNames = getTeacherInfo().ToArray();
            dDirectorComboBox.Items = teacherNames;
            dDirectorComboBox.selectedIndex = 0;
            hideLabels();
            teacherChosen.Page = 0;
        }

        private List<string> getTeacherInfo() // gets the info form DB in tables Teachers and Subjects
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM Teachers INNER JOIN Subject ON Subject.ID = Teachers.Subject_ID WHERE Special = \"Заместник-директор\"", connection);
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
                    Allteachers.Sip.Add(dr["SIP"].ToString());
                }
                Allteachers.Page.Add(int.Parse(dr["Page"].ToString()));
            }
            connection.Close();
            return Allteachers.Names;
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            getChosenTeacher();
            dDirectorNameLabel.Text = teacherChosen.Names;
            dDirectorSpecialLabel.Text = teacherChosen.Special;
            dDirectorSubjectLabel.Text = "Учител по: " + teacherChosen.Subject;
            dDirectorConsultationLabel.Text = "Има консултации в: " + teacherChosen.Consultation;
            if (teacherChosen.Sip == "")
            {
                dDirectorSipLabel.Text = "Няма въведен СИП";
            }
            else
            {
                dDirectorSipLabel.Text = "Има СИП в: " + teacherChosen.Sip;
            }
            string[] lines = System.IO.File.ReadAllLines(@"Resources\\NewProgramsTeachersFilePath.txt");
            try
            {
                programPath = lines[0];
            }
            catch (IndexOutOfRangeException ex)
            {
                programPath = "";
            }

            if (teacherChosen.Page == 0)
            {
                Point p1 = new Point();
                p1.X = -205;
                p1.Y = 480;
                Point scrPos = this.PointToScreen(p1);
                notificationForm childForm = new notificationForm("Учителят няма програма!", notificationForm.AlertType.fail, scrPos, 257);
                childForm.Show();
            }
            else
            {
                if (programPath != "")
                {
                    dDirectorProgramWebBrowser.Navigate($@"{programPath}#page={teacherChosen.Page}"); // gets the path to the new file
                }
                else
                {
                    string currentDirectory = System.IO.Directory.GetCurrentDirectory(); // gets the current directory. Nessesary due to installer
                    dDirectorProgramWebBrowser.Refresh();
                    dDirectorProgramWebBrowser.Navigate(currentDirectory + "\\" + $"Teachers\\p{teacherChosen.Page}.pdf");

                }

            }
            showLabels();
        }
        private void hideLabels()
        {
            dDirectorNameLabel.Visible = false;
            dDirectorSubjectLabel.Visible = false;
            dDirectorSipLabel.Visible = false;
            dDirectorConsultationLabel.Visible = false;
            dDirectorProgramWebBrowser.Visible = false;
            dDirectorSpecialLabel.Visible = false;
            dDirectorSubjectLabel.MaximumSize = new Size(400, 0);
            dDirectorSubjectLabel.AutoSize = true;
            dDirectorSipLabel.MaximumSize = new Size(350, 0);
            dDirectorSipLabel.AutoSize = true;
        }
        private void showLabels()
        {
            dDirectorNameLabel.Visible = true;
            dDirectorSubjectLabel.Visible = true;
            dDirectorSipLabel.Visible = true;
            dDirectorConsultationLabel.Visible = true;
            dDirectorProgramWebBrowser.Visible = true;
            dDirectorSpecialLabel.Visible = true;
        }

        public void getChosenTeacher()
        {
            teacherChosen.Names = dDirectorComboBox.selectedValue; // Find and bind the chosen teacher from combo box
            for (int i = 0; i < Allteachers.Names.Count; i++)
            {
                if (teacherChosen.Names.Equals(Allteachers.Names[i]) == true)
                {
                    teacherChosen.Names = Allteachers.Names[i];
                    teacherChosen.Subject = Allteachers.Subject[i];
                    teacherChosen.Special = Allteachers.Special[i];
                    teacherChosen.Consultation = Allteachers.Consultation[i];
                    teacherChosen.Sip = Allteachers.Sip[i];
                    teacherChosen.Page = Allteachers.Page[i];
                }
            }
        }

        private void DeputyDirectorInfoUC_Load(object sender, System.EventArgs e)
        {
            dDirectorProgramWebBrowser.Navigate("about:blank");
        }
    }
}
