namespace SchoolAssistant
{
    using System;
    using System.Data.OleDb;
    using System.Linq;
    using System.Windows.Forms;
    public partial class ChangeAddSip : Form
    {
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Teachers.accdb");
        public static AllTeachers Allteachers = new AllTeachers();
        private string teacherChosen = "";
        public ChangeAddSip()
        {
            InitializeComponent();
        }
        private void ChangeAddSip_Load(object sender, EventArgs e)
        {
            Allteachers = Main.Allteachers;
            comboBox3.DataSource = Allteachers.Names;
            textBox8.Enabled = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string Name = comboBox3.SelectedItem.ToString();
            string sip = textBox7.Text;

            OleDbCommand cmd = new OleDbCommand($"UPDATE Teachers SET SIP = '{sip}' WHERE Name='{Name}'");
            cmd.Connection = connection;

            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Часовете за СИП са сменени!");
                connection.Close();
                Application.Restart();
            }
            catch (OleDbException ex)
            {
                //MessageBox.Show(ex.Source);
                MessageBox.Show("Не са променени данни! Пишете на developer@email.com");
                connection.Close();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            teacherChosen = comboBox3.SelectedItem.ToString();
            for (int i = 0; i < Allteachers.Names.Count; i++)
            {
                if (teacherChosen == Allteachers.Names[i])
                {
                    if (Allteachers.sip[i] == "")
                    {
                        textBox8.Text = "Няма СИП.";
                    }
                    else
                    {
                        textBox8.Text = Allteachers.sip[i];
                    }
                }
            }
        }
    }
}
