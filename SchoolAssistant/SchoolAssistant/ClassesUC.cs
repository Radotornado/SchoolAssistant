namespace SchoolAssistant
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Windows.Forms;

    public partial class ClassesUC : UserControl
    {
        private static ClassesUC _instance;
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Resources\Teachers.accdb"); // Include DB
        public string programPath = "";
        private static Classes classes = new Classes();
        private string classChosen = "";
        private int page = 0;

        public static ClassesUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClassesUC();
                return _instance;
            }
            set { }
        }
        public ClassesUC()
        {
            InitializeComponent();

            classChosen = MainForm.classChosen;

            string[] classesNames = getClassInfo().ToArray();
            classesComboBox.Items = classesNames;
            classesComboBox.selectedIndex = 0;

            hideLabels();

            classChosen = " ";
        }
        public List<string> getClassInfo() // gets the name and the class teacher form DB in table Classes 
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM Classes", connection);
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter(com);
            ad.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                classes.className.Add(dr["ClassNames"].ToString());
                classes.classTeacher.Add(dr["Teacher"].ToString());
                classes.page.Add(int.Parse(dr["Page"].ToString()));
            }
            connection.Close();
            return classes.className;
        }

        private void ClassesUserControl_Load(object sender, System.EventArgs e)
        {
            classProgramWebBrowser.Navigate("about:blank");
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            getChosenClass();
            string[] lines = System.IO.File.ReadAllLines(@"Resources\\NewProgramsClassesFilePath.txt");
            try
            {
                programPath = lines[0];
            }
            catch (IndexOutOfRangeException ex)
            {
                programPath = "";
            }

            if (page == 0)
            {
                MessageBox.Show("Класът няма програма!");
            }
            else
            {
                if (programPath != "")
                {
                    classProgramWebBrowser.Navigate($@"{programPath}#page={page}"); // gets the path to the new file
                }
                else
                {
                    string currentDirectory = System.IO.Directory.GetCurrentDirectory(); // gets the current directory. Nessesary due to installer
                    classProgramWebBrowser.Refresh();
                    classProgramWebBrowser.Navigate(currentDirectory + "\\" + $"Classes\\p{page}.pdf");

                }

            }
            showLabels();
        }
        private void hideLabels()
        {
            classTeacherLabel.Visible = false;
            classNameLabel.Visible = false;
            classProgramWebBrowser.Visible = false;
        }
        private void showLabels()
        {
            classTeacherLabel.Visible = true;
            classNameLabel.Visible = true;
            classProgramWebBrowser.Visible = true;
        }

        public void getChosenClass()
        {
            classChosen = classesComboBox.selectedValue; // Find and bind the chosen teacher from combo box
            for (int i = 0; i < classes.className.Count; i++)
            {
                if (classChosen.Equals(classes.className[i]) == true)
                {
                    classNameLabel.Text = classes.className[i] + " клас";
                    classTeacherLabel.Text = "Класен ръководител: " + classes.classTeacher[i];
                    page = classes.page[i];
                }
            }
        }
    }
}
