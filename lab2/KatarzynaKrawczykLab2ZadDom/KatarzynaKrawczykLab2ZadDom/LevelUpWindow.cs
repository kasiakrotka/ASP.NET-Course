using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatarzynaKrawczykLab2ZadDom
{
    public partial class LevelUpWindow : Form
    {
        public int Choice { get; set; }//potrzebne do przekazania wyboru użytkownika 
        public LevelUpWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// zmienia wartosc wyboru o statystyce do podniesienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (radioButtonMaxDamage.Checked)
                Choice = 1;
            if (radioButtonCritical.Checked)
                Choice = 2;
            if (radioButtonDodge.Checked)
                Choice = 3;
            this.Close();
        }
    }
}
