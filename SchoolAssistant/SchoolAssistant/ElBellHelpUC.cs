namespace SchoolAssistant
{
    using System.Windows.Forms;

    public partial class ElBellHelpUC : UserControl
    {
        private static ElBellHelpUC _instance;
        public static ElBellHelpUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ElBellHelpUC();
                return _instance;
            }
            set { }
        }
        public ElBellHelpUC()
        {
            InitializeComponent();
        }
    }
}
