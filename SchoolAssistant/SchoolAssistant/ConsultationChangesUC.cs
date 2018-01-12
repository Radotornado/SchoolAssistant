namespace SchoolAssistant
{
    using System.Data.OleDb;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class ConsultationChangesUC : UserControl
    {
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Resources\Teachers.accdb");
        private string teacherChosen = "";
        private static AllTeachers Allteachers = new AllTeachers();
        private static ConsultationChangesUC _instance;

        public static ConsultationChangesUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConsultationChangesUC();
                return _instance;
            }
            set { }
        }
        public ConsultationChangesUC()
        {
            InitializeComponent();
        }

        private void ConsultationChangesUC_Load(object sender, System.EventArgs e)
        {
            Allteachers = MainForm.Allteachers;
            teacherNamesComboBox.Items = Allteachers.Names.ToArray();
            oldConsultationsTB.Enabled = false;
            teacherNamesComboBox.selectedIndex = 0;
            Point p1 = new Point();
            p1.X = -205;
            p1.Y = 480;
            Point scrPos = this.PointToScreen(p1);
            notificationForm childForm = new notificationForm("При всяка една промяна приложението ще се рестартира!", notificationForm.AlertType.fail, scrPos, 536);
            childForm.Show();
        }

        private void changeConsultationButton_Click(object sender, System.EventArgs e)
        {
            if (newConsultationsTB.Text != "")
            {
                string Name = teacherNamesComboBox.selectedValue.ToString();
                string Consultation = newConsultationsTB.Text;

                OleDbCommand cmd = new OleDbCommand($"UPDATE Teachers SET Consultation = '{Consultation}' WHERE Name='{Name}'");
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
            else
            {
                Point p1 = new Point();
                p1.X = -205;
                p1.Y = 480;
                Point scrPos = this.PointToScreen(p1);
                notificationForm childForm = new notificationForm("Полето не може да е празно!", notificationForm.AlertType.fail, scrPos, 289);
                childForm.Show();
            }
        }

        private void teacherNamesComboBox_onItemSelected(object sender, System.EventArgs e)
        {
            teacherChosen = teacherNamesComboBox.selectedValue.ToString();
            for (int i = 0; i < Allteachers.Names.Count; i++)
            {
                if (teacherChosen == Allteachers.Names[i])
                {
                    oldConsultationsTB.Text = Allteachers.Consultation[i];
                }
            }
        }
    }
}
