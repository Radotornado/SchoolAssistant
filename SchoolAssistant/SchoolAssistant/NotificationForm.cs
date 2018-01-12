namespace SchoolAssistant
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class notificationForm : Form
    {
        private Point m_Location;
        public notificationForm(string _message, AlertType type, Point location, int notificWidth)
        {
            InitializeComponent();

            m_Location = location;

            textLabel.Text = _message;

            this.Width = notificWidth;

            switch (type){
                case AlertType.noElBells:
                    this.BackColor = Color.Red;
                    tickLogoPictureBox.Image = Image.FromFile(@"Images\whiteCrossedBell.png");
                    
                    break;
                case AlertType.success:
                    this.BackColor = Color.Green;
                    tickLogoPictureBox.Image = Image.FromFile(@"Images\whiteTick.png");
                    break;
                case AlertType.fail:
                    this.BackColor = Color.Red;
                    tickLogoPictureBox.Image = Image.FromFile(@"Images\whiteX.png");
                    break;
            }


        }
        

        public enum AlertType
        {
            noElBells, success, fail
        }

        private void notificationForm_Load(object sender, EventArgs e)
        {
            this.Location = m_Location;
            timeIn.Start();
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity-=0.02; // reduce opacity to fade out
            }
            else
            {
                this.Close();
            }
        }

        private void timeOut_Tick(object sender, EventArgs e)
        {
            closeTimer.Start();
        }
        private void timeIn_Tick(object sender, EventArgs e)
        {
        }
    }
}
