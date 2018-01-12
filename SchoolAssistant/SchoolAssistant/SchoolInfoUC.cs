namespace SchoolAssistant
{
    using System.Windows.Forms;

    public partial class SchoolInfoUC : UserControl
    {
        private static SchoolInfoUC _instance;
        public static SchoolInfoUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SchoolInfoUC();
                return _instance;
            }
            set { }
        }
        public SchoolInfoUC()
        {
            InitializeComponent();
        }
    }
}
