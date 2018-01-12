namespace SchoolAssistant
{
    using System;
    using System.Windows.Forms;

    public partial class DirectorInfoUC : UserControl
    {
        private static DirectorInfoUC _instance;
        public string programPath = "";

        public static DirectorInfoUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DirectorInfoUC();
                return _instance;
            }
            set { }
        }
        public DirectorInfoUC()
        {
            InitializeComponent();
        }

        private void DirectorInfoUC_Load(object sender, System.EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"Resources\\NewProgramsTeachersFilePath.txt");
            try
            {
                programPath = lines[0];
            }
            catch (IndexOutOfRangeException ex)
            {
                programPath = "";
            }
            if (programPath != "")
            {
                //teacherProgramWebBrowser.Navigate($@"{programPath}#page={teacherChosen.Page}"); // gets the path to the new file
            }
            else
            {
                string currentDirectory = System.IO.Directory.GetCurrentDirectory(); // gets the current directory. Nessesary due to installer
                directorProgramWebBrowser.Refresh();
                directorProgramWebBrowser.Navigate(currentDirectory + "\\" + $"Teachers\\p{65}.pdf");

            }
        }
    }
}
