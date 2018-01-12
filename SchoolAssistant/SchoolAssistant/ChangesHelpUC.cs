namespace SchoolAssistant
{
    using System.Windows.Forms;

    public partial class ChangesHelpUC : UserControl
    {
        private static ChangesHelpUC _instance;
        public static ChangesHelpUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ChangesHelpUC();
                return _instance;
            }
            set { }
        }

        public ChangesHelpUC()
        {
            InitializeComponent();
        }
    }
}
