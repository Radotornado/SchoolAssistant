namespace SchoolAssistant
{
    using System.Windows.Forms;

    public partial class SchoolAssistantInfoUC : UserControl
    {
        private static SchoolAssistantInfoUC _instance;
        public static SchoolAssistantInfoUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SchoolAssistantInfoUC();
                return _instance;
            }
            set { }
        }
        public SchoolAssistantInfoUC()
        {
            InitializeComponent();
        }


    }
}
