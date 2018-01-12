namespace SchoolAssistant
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class ClassTeacherChangeUC : UserControl
    {
        private static ClassTeacherChangeUC _instance;
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Resources\Teachers.accdb");
        private string classChosen = "";
        private static Classes classes = new Classes();
        private static AllTeachers Allteachers = new AllTeachers();

        public static ClassTeacherChangeUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClassTeacherChangeUC();
                return _instance;
            }
            set { }
        }

        public ClassTeacherChangeUC()
        {
            InitializeComponent();
        }

        private void ClassTeacherChangeUC_Load(object sender, System.EventArgs e)
        {
            Allteachers = MainForm.Allteachers;
            getClassInfo();
            classNamesComboBox.Items = classes.className.ToArray();
            newClassTeacherComboBox.Items = Allteachers.Names.ToArray();
            oldClassTeacherTextBox.Enabled = false;
            classNamesComboBox.selectedIndex = 0;
            newClassTeacherComboBox.selectedIndex = 0;

            Point p1 = new Point();
            p1.X = -205;
            p1.Y = 480;
            Point scrPos = this.PointToScreen(p1);
            notificationForm childForm = new notificationForm("При всяка една промяна приложението ще се рестартира!", notificationForm.AlertType.fail, scrPos, 536);
            childForm.Show();
        }

        private void changeClassTeacherButton_Click(object sender, System.EventArgs e)
        {
            string Name = classNamesComboBox.selectedValue.ToString();
            string newClassTeacher = newClassTeacherComboBox.selectedValue.ToString();

            OleDbCommand cmd = new OleDbCommand($"UPDATE Classes SET Teacher = '{newClassTeacher}' WHERE ClassNames='{Name}'");
            cmd.Connection = connection;

            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                connection.Close();
                Application.Restart();
            }
            catch (OleDbException ex)
            {
                //MessageBox.Show(ex.Source);
                Point p1 = new Point();
                p1.X = -205;
                p1.Y = 480;
                Point scrPos = this.PointToScreen(p1);
                notificationForm childForm = new notificationForm("Не са изтрити данни! Пишете на developer@email.com!", notificationForm.AlertType.fail, scrPos, 497);
                childForm.Show();
                connection.Close();
            }
        }

        private void classNamesComboBox_onItemSelected(object sender, System.EventArgs e)
        {
            classChosen = classNamesComboBox.selectedValue.ToString();
            for (int i = 0; i < classes.className.Count; i++)
            {
                if (classChosen == classes.className[i])
                {
                    oldClassTeacherTextBox.Text = classes.classTeacher[i];
                }
            }
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
    }
}
