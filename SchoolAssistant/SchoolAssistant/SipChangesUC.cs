namespace SchoolAssistant
{
    using System.Data.OleDb;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class SipChangesUC : UserControl
    {
        private static SipChangesUC _instance;
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Resources\Teachers.accdb"); // Include DB
        public static AllTeachers Allteachers = new AllTeachers();
        private string teacherChosen = "";

        public static SipChangesUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SipChangesUC();
                return _instance;
            }
            set { }
        }

        public SipChangesUC()
        {
            InitializeComponent();
        }

        private void teacherNamesComboBox_onItemSelected(object sender, System.EventArgs e)
        {
            teacherChosen = teacherNamesComboBox.selectedValue.ToString();
            for (int i = 0; i < Allteachers.Names.Count; i++)
            {
                if (teacherChosen == Allteachers.Names[i])
                {
                    if (Allteachers.Sip[i] == "")
                    {
                        oldClassesTB.Text = "Няма СИП.";
                    }
                    else
                    {
                        oldClassesTB.Text = Allteachers.Sip[i];
                    }
                }
            }
        }

        private void SipChangesUC_Load(object sender, System.EventArgs e)
        {
            Allteachers = MainForm.Allteachers;
            teacherNamesComboBox.Items = Allteachers.Names.ToArray();
            oldClassesTB.Enabled = false;
            teacherNamesComboBox.selectedIndex = 0;

            Point p1 = new Point();
            p1.X = -205;
            p1.Y = 480;
            Point scrPos = this.PointToScreen(p1);
            notificationForm childForm = new notificationForm("При всяка една промяна приложението ще се рестартира!", notificationForm.AlertType.fail, scrPos, 536);
            childForm.Show();
        }

        private void changeSipButton_Click(object sender, System.EventArgs e)
        {
            string Name = teacherNamesComboBox.selectedValue.ToString();
            string sip = newClassesTB.Text;

            OleDbCommand cmd = new OleDbCommand($"UPDATE Teachers SET SIP = '{sip}' WHERE Name='{Name}'");
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
    }
}
