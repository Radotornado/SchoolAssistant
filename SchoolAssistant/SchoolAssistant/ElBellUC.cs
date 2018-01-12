namespace SchoolAssistant
{
    using System;
    using System.Drawing;
    using System.IO.Ports;
    using System.Windows.Forms;

    public partial class ElBellUC : UserControl
    {
        private static ElBellUC _instance;

        private string[] linesOnce = System.IO.File.ReadAllLines(@"Resources\once.txt");
        private string[] linesTwice = System.IO.File.ReadAllLines(@"Resources\twice.txt");
        private static Time timeNow = new Time();
        private string[] ports = SerialPort.GetPortNames();

        public static ElBellUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ElBellUC();
                return _instance;
            }
            set { }
        }
        public ElBellUC()
        {
            InitializeComponent();
        }

        private void ElBellUserControl_Load(object sender, System.EventArgs e)
        {
            // for possible future changing to class times
            classTimesLabel.Text = $@"
№     I смяна           II смяна

1    {linesTwice[0].Substring(0, 5)} {linesOnce[1].Substring(0, 5)}      {linesTwice[7].Substring(0, 5)} {linesOnce[15].Substring(0, 5)} 
2    {linesTwice[1].Substring(0, 5)} {linesOnce[3].Substring(0, 5)}      {linesTwice[8].Substring(0, 5)} {linesOnce[17].Substring(0, 5)} 
3    {linesTwice[2].Substring(0, 5)} {linesOnce[5].Substring(0, 5)}      {linesTwice[9].Substring(0, 5)} {linesOnce[19].Substring(0, 5)} 
4    {linesTwice[3].Substring(0, 5)} {linesOnce[7].Substring(0, 5)}      {linesTwice[10].Substring(0, 5)} {linesOnce[21].Substring(0, 5)} 
5    {linesTwice[4].Substring(0, 5)} {linesOnce[9].Substring(0, 5)}      {linesTwice[11].Substring(0, 5)} {linesOnce[23].Substring(0, 5)} 
6    {linesTwice[5].Substring(0, 5)} {linesOnce[11].Substring(0, 5)}      {linesTwice[12].Substring(0, 5)} {linesOnce[25].Substring(0, 5)}
7    {linesTwice[6].Substring(0, 5)} {linesOnce[13].Substring(0, 5)}      {linesTwice[13].Substring(0, 5)} {linesOnce[25].Substring(0, 5)}
";
            elBellMessageLabel.Text = "Електронният звънец е изключен.";

            comPortsComboBox.Items = ports;
            if (comPortsComboBox.Items.Length != 0) comPortsComboBox.selectedIndex = 0; // check for possible COM ports
            offButton.Enabled = false;
        }

        private void onButton_Click(object sender, System.EventArgs e)
        {
            if (comPortsComboBox.selectedIndex >= 0)
            {
                offButton.Enabled = true;
                onButton.Enabled = false;
                elBellMessageLabel.MaximumSize = new Size(320, 0);
                elBellMessageLabel.Text = $"Електронният звънец е включен на порт {comPortsComboBox.selectedValue}"; // sets name of port 
            }
            else
            {
                Point p1 = new Point();
                p1.X = -205;
                p1.Y = 480;
                Point scrPos = this.PointToScreen(p1);
                notificationForm childForm = new notificationForm("Няма включен електронен звънец!", notificationForm.AlertType.noElBells, scrPos, 324);
                childForm.Show();
            }
        }

        private void offButton_Click(object sender, System.EventArgs e)
        {
            offButton.Enabled = false;
            onButton.Enabled = true;
            elBellMessageLabel.Text = "Електронният звънец е изключен.";
        }

        private void alarmButton_Click(object sender, System.EventArgs e)
        {
            alarm();
        }

        private void whenToRing()
        {
            if (offButton.Enabled == true) // checks if enabled
            {
                if (DateTime.Now.DayOfWeek != DayOfWeek.Saturday && DateTime.Now.DayOfWeek != DayOfWeek.Sunday) // checks when to ring
                {
                    for (int i = 0; i < linesTwice.Length; i++) // checks when to ring once or twice
                    {
                        if (DateTime.Now.TimeOfDay.ToString(@"hh\:mm\:ss") == linesTwice[i])
                        {
                            dualRing();
                            break;
                        }
                    }
                    for (int i = 0; i < linesOnce.Length; i++)
                    {
                        if (DateTime.Now.TimeOfDay.ToString(@"hh\:mm\:ss") == linesOnce[i])
                        {
                            singleRing();
                            break;
                        }
                    }
                }
            }
        }

        private void singleRing() // sends a command through serial port for arduino
        {
            SerialPort serial = new SerialPort(comPortsComboBox.selectedValue.ToString(), 9600);
            serial.Open();
            serial.WriteLine("A");
            serial.Close();
        }
        private void dualRing() // sends a command through serial port for arduino
        {
            SerialPort serial = new SerialPort(comPortsComboBox.selectedValue.ToString(), 9600);
            serial.Open();
            serial.WriteLine("B");
            serial.Close();

        }
        public void alarm() // sends a command through serial port for arduino
        {
            SerialPort serial = new SerialPort(comPortsComboBox.selectedValue.ToString(), 9600);
            serial.Open();
            serial.WriteLine("C");
            serial.Close();
        }
    }
}

