using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyber_Tarot
{
    public partial class frmBasicReading : Form
    {
        public frmBasicReading()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Past/Present/Future")
            {
                navigation.navigateForms("basic");
            }
        }
    }
}
