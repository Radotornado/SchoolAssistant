using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoNameYet
{
    public partial class HelpMainForm : Form
    {
        public HelpMainForm()
        {
            InitializeComponent();
        }

        private void HelpMainForm_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
