namespace SchoolAssistant
{
    using System.Data;
    using System.Data.OleDb;
    using System.Windows.Forms;

    public partial class YourClassInfoUC : UserControl
    {
        private static YourClassInfoUC _instance;
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Resources\Teachers.accdb"); // Include DB
        private YourClass yourClassInfo = new YourClass();

        public static YourClassInfoUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new YourClassInfoUC();
                return _instance;
            }
            set { }
        }
        public YourClassInfoUC()
        {
            InitializeComponent();

            yourClassInfo = MainForm.yourClassInfo;
        }

        private void YourClassInfoUC_Load(object sender, System.EventArgs e)
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM YourClass", connection);
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter(com);
            ad.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                yourClassInfo.Groups.Add(dr["Group"].ToString());
                yourClassInfo.Teachers.Add(dr["Teacher"].ToString());
            }
            connection.Close();
            yourClassDataGridView.Rows.Add(29);
            for (int i = 0; i < yourClassInfo.Groups.Count; i++)
            {
                yourClassDataGridView[0, i].Value = yourClassInfo.Groups[i];
                yourClassDataGridView[1, i].Value = yourClassInfo.Teachers[i];
            }
        }
    }
}
