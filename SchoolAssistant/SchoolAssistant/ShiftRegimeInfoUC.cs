namespace SchoolAssistant
{
    using System;
    using System.Windows.Forms;

    public partial class ShiftRegimeInfoUC : UserControl
    {
        private static ShiftRegimeInfoUC _instance;
        public static ShiftRegimeInfoUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ShiftRegimeInfoUC();
                return _instance;
            }
            set { }
        }
        public ShiftRegimeInfoUC()
        {
            InitializeComponent();
        }

        private void ShiftRegimeInfoUC_Load(object sender, System.EventArgs e)
        {
            shiftRegimeLabel.Text = $@"Сменен режим през учебната 2017/2018 година
15.09.2017г. - 27.10.2017г.
15.09.2017г. - 27.10.2017г.
30.10.2017г. - 23.12.2017г.
03.01.2018г. - 23.02.2018г.
26.02.2018г. - 30.03.2018г.
10.04.2018г. - 01.06.2018г.
04.06.2018г. - 29.06.2018г.
";
            //gets current date in this format
        }
    }
}
