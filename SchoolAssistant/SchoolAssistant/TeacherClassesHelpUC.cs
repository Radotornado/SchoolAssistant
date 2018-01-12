namespace SchoolAssistant
{
    using System.Windows.Forms;

    public partial class TeacherClassesHelpUC : UserControl
    {
        private static TeacherClassesHelpUC _instance;
        public static TeacherClassesHelpUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TeacherClassesHelpUC();
                return _instance;
            }
            set { }
        }
        public TeacherClassesHelpUC()
        {
            InitializeComponent();
        }
        
    }
}
