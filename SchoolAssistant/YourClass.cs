namespace SchoolAssistant
{
    using System;
    using System.Windows.Forms;

    public partial class YourClass : Form
    {
        public YourClass()
        {
            InitializeComponent();
        }

        private void YourClass_Load(object sender, EventArgs e)
        {
            // add lines form text file to dataGridView
            string[] lines = System.IO.File.ReadAllLines(@"yourClass.txt");
            dataGridView1.Rows.Add(26); 
            int n = 0;
            for (int i = 0; i < 27; i++)
            {
                dataGridView1[0, i].Value = lines[i];
            }
            for (int i = 27; i < 54; i++)
            {
                dataGridView1[1, n].Value = lines[i];
                n++;
            }
        }
    }
}
