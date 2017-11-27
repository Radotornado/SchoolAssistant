namespace SchoolAssistant
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Windows.Forms;

    public partial class AddRemoveTeacher : Form
    {
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Teachers.accdb");
        private int subjectID = 0;
        private List<string> subjects = new List<string>();
        private List<int> subjectIDS = new List<int>();
        public AddRemoveTeacher()
        {
            InitializeComponent();
        }

        private void AddRemoveTeacher_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = getListOfSubjects();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                subjectID = comboBox1.SelectedIndex + 2;
                string Name = textBox1.Text;
                string Subject = comboBox1.SelectedItem.ToString();
                string Special = textBox3.Text;
                string Subject_ID = subjectID.ToString();
                string Consultation = textBox2.Text;

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
                    MessageBox.Show("Учителят е добавен!");
                    connection.Close();
                    Application.Restart();
                }
                catch (OleDbException ex)
                {
                    //MessageBox.Show(ex.Source);
                    MessageBox.Show("Не са добавени данни! Пишете на developer@email.com");
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Името и консултациите са задължителни!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {

                OleDbCommand cmd = new OleDbCommand($"Delete from Teachers where name='{textBox6.Text}'");
                cmd.Connection = connection;
                connection.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Учителят е изтрит!");
                    connection.Close();
                    Application.Restart();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Не са изтрити данни! Пишете на developer@email.com");
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Името е задължително!");
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
    }
}
