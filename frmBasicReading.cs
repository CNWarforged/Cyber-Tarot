using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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

        private void frmBasicReading_Load(object sender, EventArgs e)
        {


            int key = 7;
            var tarotCard = new TarotCard();
            tarotCard = dbAccess.ReadDB(key);

            MessageBox.Show(tarotCard.Name);

            lblPastName.Text = tarotCard.Name;
            tBoxPast.Text = tarotCard.ShortDescription;


        }
    }
}
