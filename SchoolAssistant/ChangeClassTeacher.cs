namespace SchoolAssistant
{
    using System;
    using System.Data.OleDb;
    using System.Windows.Forms;

    public partial class ChangeClassTeacher : Form
    {
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Teachers.accdb");
        private string classChosen = "";
        private static Classes classes = new Classes();
        private static AllTeachers Allteachers = new AllTeachers();
        public ChangeClassTeacher()
        {
            InitializeComponent();
        }
        private void ChangeClassTeacher_Load(object sender, EventArgs e)
        {
            classes = Main.classes;
            Allteachers = Main.Allteachers;
            comboBox2.DataSource = classes.className;
            comboBox1.DataSource = Allteachers.Names;
            textBox4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Name = comboBox2.SelectedItem.ToString();
            string newClassTeacher = comboBox1.SelectedItem.ToString();

            OleDbCommand cmd = new OleDbCommand($"UPDATE Classes SET Teacher = '{newClassTeacher}' WHERE ClassNames='{Name}'");
            cmd.Connection = connection;

            connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Класният ръководител е сменен!");
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            classChosen = comboBox2.SelectedItem.ToString();
            for (int i = 0; i < classes.className.Count; i++)
            {
                if (classChosen == classes.className[i])
                {
                    textBox4.Text = classes.classTeacher[i];
                }
            }
        }


    }
}
