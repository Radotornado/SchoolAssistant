namespace SchoolAssistant
{
    using System.Windows.Forms;

    public partial class HelpMainForm : Form
    {
        public HelpMainForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HelpChanges helpChangesForm = new HelpChanges();
            helpChangesForm.Show();
            this.Hide();
        }
    }
}
