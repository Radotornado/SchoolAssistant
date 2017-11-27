namespace SchoolAssistant
{
    using System;
    using System.Drawing;
    using System.IO.Ports;
    using System.Timers;
    using System.Windows.Forms;

    public partial class ElBell : Form
    {
        private string[] linesOnce = System.IO.File.ReadAllLines(@"once.txt");
        private string[] linesTwice = System.IO.File.ReadAllLines(@"twice.txt");
        private static Time timeNow = new Time();
        private System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        private string[] ports = SerialPort.GetPortNames();
        public ElBell()
        {
            InitializeComponent();
            timeNow = Main.timeNow;
        }

        private void Times_Load(object sender, EventArgs e)
        {
            // for possible future changing to class times
            label1.Text = $@"
№     I смяна           II смяна

1    {linesTwice[0].Substring(0, 5)} {linesOnce[1].Substring(0, 5)}      {linesTwice[7].Substring(0, 5)} {linesOnce[15].Substring(0, 5)} 
2    {linesTwice[1].Substring(0, 5)} {linesOnce[3].Substring(0, 5)}      {linesTwice[8].Substring(0, 5)} {linesOnce[17].Substring(0, 5)} 
3    {linesTwice[2].Substring(0, 5)} {linesOnce[5].Substring(0, 5)}      {linesTwice[9].Substring(0, 5)} {linesOnce[19].Substring(0, 5)} 
4    {linesTwice[3].Substring(0, 5)} {linesOnce[7].Substring(0, 5)}      {linesTwice[10].Substring(0, 5)} {linesOnce[21].Substring(0, 5)} 
5    {linesTwice[4].Substring(0, 5)} {linesOnce[9].Substring(0, 5)}      {linesTwice[11].Substring(0, 5)} {linesOnce[23].Substring(0, 5)} 
6    {linesTwice[5].Substring(0, 5)} {linesOnce[11].Substring(0, 5)}      {linesTwice[12].Substring(0, 5)} {linesOnce[25].Substring(0, 5)}
7    {linesTwice[6].Substring(0, 5)} {linesOnce[13].Substring(0, 5)}      {linesTwice[13].Substring(0, 5)} {linesOnce[25].Substring(0, 5)}
";
            label5.Text = "Електронният звънец е изключен.";


            t.Enabled = true;
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();

            foreach (string port in ports) comboBox1.Items.Add(port); 
            if (comboBox1.Items.Count != 0) comboBox1.SelectedIndex = 0; // check for possible COM ports
            else MessageBox.Show("Няма включен електронен звънец!"); 
            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            label5.MaximumSize = new Size(250, 0);
            label5.Text = $"Електронният звънец е включен на порт {comboBox1.SelectedItem}"; // sets name of port 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            label5.Text = "Електронният звънец е изключен.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = "";
            if (hh < 10) time += "0" + hh;
            else time += hh;
            time += ":";
            if (mm < 10) time += "0" + mm;
            else time += mm;
            time += ":";
            if (ss < 10) time += "0" + ss;
            else time += ss;
            label4.Text = "Сега е " + time + " часът.";
            whenToRing();
            if (timeNow.dateInClass != "") label3.Text = timeNow.dateInClass;
            else label3.Text = timeNow.dateNoClass;
        }
        private void singleRing() // sends a command through serial port for arduino
        {
            SerialPort serial = new SerialPort(comboBox1.SelectedItem.ToString(), 9600);
            serial.Open();
            serial.WriteLine("A"); 
            serial.Close();
        }
        private void dualRing() // sends a command through serial port for arduino
        {
            SerialPort serial = new SerialPort(comboBox1.SelectedItem.ToString(), 9600);
            serial.Open();
            serial.WriteLine("B");
            serial.Close();

        }
        public void alarm() // sends a command through serial port for arduino
        {
            SerialPort serial = new SerialPort(comboBox1.SelectedItem.ToString(), 9600);
            serial.Open();
            serial.WriteLine("C");
            serial.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alarm();
        }
        private void whenToRing()
        {
            if (button1.Enabled == true) // checks if enabled
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

        internal void Schow()
        {
            throw new NotImplementedException();
        }
    }
}
