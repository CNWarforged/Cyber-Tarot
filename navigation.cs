using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyber_Tarot
{
    internal class navigation
    {
        public static void navigateForms(string chosenForm)
        {
            if (chosenForm == "basic")
            {
                frmBasicReading openForm = new frmBasicReading();
                openForm.ShowDialog();
            }

            
            return;
        }
    }
}
