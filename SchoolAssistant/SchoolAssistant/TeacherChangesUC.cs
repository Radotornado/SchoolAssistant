namespace SchoolAssistant
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public partial class TeacherChangesUC : UserControl
    {
        private static TeacherChangesUC _instance;
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Resources\Teachers.accdb");
        private int subjectID = 0;
        private List<string> subjects = new List<string>();
        private List<int> subjectIDS = new List<int>();
        private List<string> teacherNames = new List<string>();
        private List<int> teacherNamesIDS = new List<int>();
        private string pathTeachers = @"Resources\\NewProgramsTeachersFilePath.txt";

        public static TeacherChangesUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TeacherChangesUC();
                return _instance;
            }
            set { }
        }
        public TeacherChangesUC()
        {
            InitializeComponent();
        }

        private void addTeacherButton_Click(object sender, System.EventArgs e)
        {
            if (nameTextBox.Text != "" && consultationTextBox.Text != "")
            {
                subjectID = teachersComboBox.selectedIndex + 2;
                string Name = nameTextBox.Text;
                string Subject = teachersComboBox.selectedValue.ToString();
                string Special = specialTextBox.Text;
                string Subject_ID = subjectID.ToString();
                string Consultation = consultationTextBox.Text;

                OleDbCommand cmd = new OleDbCommand("INSERT into Teachers (Name, Subject_ID, Special, Consultation) Values(@Name, @Subject_ID, @Special, @Consultation)");
                cmd.Connection = connection;

                connection.Open();
                cmd.Parameters.Add("@Name", OleDbType.VarChar).Value = Name;
                cmd.Parameters.Add("@Subject_ID", OleDbType.VarChar).Value = Subject_ID;
                cmd.Parameters.Add("@Special", OleDbType.VarChar).Value = Special;
                cmd.Parameters.Add("@Consultation", OleDbType.VarChar).Value = Consultation;
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
                    notificationForm childForm = new notificationForm("Не са добавени данни! Пишете на developer@email.com!", notificationForm.AlertType.fail, scrPos, 497);
                    childForm.Show();
                    connection.Close();
                }
            }
            else
            {
                Point p1 = new Point();
                p1.X = -205;
                p1.Y = 480;
                Point scrPos = this.PointToScreen(p1);
                notificationForm childForm = new notificationForm("Името и консултацията са задължителни!", notificationForm.AlertType.fail, scrPos, 380);
                childForm.Show();
            }
        }
        public List<string> getListOfSubjects()
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM Subject", connection);
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter(com);
            ad.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                subjects.Add(dr["SubjName"].ToString());
                subjectIDS.Add(int.Parse(dr["ID"].ToString()));
            }
            connection.Close();
            return subjects;
        }

        public List<string> getListOfTeachers()
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM Teachers", connection);
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter(com);
            ad.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                teacherNames.Add(dr["Name"].ToString());
                teacherNamesIDS.Add(int.Parse(dr["ID"].ToString()));
            }
            connection.Close();
            return teacherNames;
        }

        private void TeacherChangesUC_Load(object sender, System.EventArgs e)
        {
            teachersComboBox.Items = getListOfSubjects().ToArray();
            teachersComboBox.selectedIndex = 0;
            teacherNamesComboBox.Items = getListOfTeachers().ToArray();
            teacherNamesComboBox.selectedIndex = 0;

            Point p1 = new Point();
            p1.X = -205;
            p1.Y = 480;
            Point scrPos = this.PointToScreen(p1);
            notificationForm childForm = new notificationForm("При всяка една промяна приложението ще се рестартира!", notificationForm.AlertType.fail, scrPos, 536);
            childForm.Show();
        }

        private void removeTeacherButton_Click(object sender, System.EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand($"Delete from Teachers where name='{teacherNamesComboBox.selectedValue}'");
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
                Point p1 = new Point();
                p1.X = -205;
                p1.Y = 480;
                Point scrPos = this.PointToScreen(p1);
                notificationForm childForm = new notificationForm("Не са изтрити данни! Пишете на developer@email.com!", notificationForm.AlertType.fail, scrPos, 497);
                childForm.Show();
                connection.Close();
            }
        }

        private void bunifuFlatButton1_Click(object sender, System.EventArgs e)
        {
            if (changeTeacherProgramFD.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(changeTeacherProgramFD.FileName);
            }

            if (MessageBox.Show("Сигурни ли сте? Старият файл ще се замени. При натискане на \"No\" ще се зададе файлът по подразбиране.", "Нужно е потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.WriteAllText(pathTeachers, String.Empty); // saves the new asked directory in text file
                using (FileStream fs = new FileStream(pathTeachers, FileMode.OpenOrCreate))
                {
                    using (TextWriter tw = new StreamWriter(fs))
                    {
                        tw.WriteLine(changeTeacherProgramFD.FileName);
                    }
                }

            }
            else
            {
                File.WriteAllText(pathTeachers, String.Empty);
            }
        }
    }
}

