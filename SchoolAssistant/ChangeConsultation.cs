namespace SchoolAssistant
{
    using System;
    using System.Data.OleDb;
    using System.Windows.Forms;

    public partial class ChangeConsultation : Form
    {
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Teachers.accdb");
        private string teacherChosen = "";
        private static AllTeachers Allteachers = new AllTeachers();
        public ChangeConsultation()
        {
            InitializeComponent();
        }
        private void ChangeConsultation_Load(object sender, EventArgs e)
        {
            Allteachers = Main.Allteachers;
            comboBox2.DataSource = Allteachers.Names;
            textBox4.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                string Name = comboBox2.SelectedItem.ToString();
                string Consultation = textBox5.Text;

                OleDbCommand cmd = new OleDbCommand($"UPDATE Teachers SET Consultation = '{Consultation}' WHERE Name='{Name}'");
                cmd.Connection = connection;

                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Часовете са сменени!");
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
            else
            {
                MessageBox.Show("Полето не може да е празно!");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            teacherChosen = comboBox2.SelectedItem.ToString();
            for (int i = 0; i < Allteachers.Names.Count; i++)
            {
                if (teacherChosen == Allteachers.Names[i])
                {
                    textBox4.Text = Allteachers.Consultation[i];
                }
            }
        }

        
    }
}
