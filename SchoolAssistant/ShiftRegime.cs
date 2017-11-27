using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAssistant
{
    public partial class ShiftRegime : Form
    {
        public ShiftRegime()
        {
            InitializeComponent();
        }

        private void ShiftRegime_Load(object sender, EventArgs e)
        {
            label1.Text = $@"Сменен режим през учебната 2017/2018 година
15.09.2017г. - 27.10.2017г.
15.09.2017г. - 27.10.2017г.
30.10.2017г. - 23.12.2017г.
03.01.2018г. - 23.02.2018г.
26.02.2018г. - 30.03.2018г.
10.04.2018г. - 01.06.2018г.
04.06.2018г. - 29.06.2018г.

Днес е {DateTime.Now.Date.ToString(@"dd/MM/yyyy")}г. 
";
            //gets current date in this format
        }
    }
}
