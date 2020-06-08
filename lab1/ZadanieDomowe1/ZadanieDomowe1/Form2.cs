using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieDomowe1
{
    public partial class Form2 : Form
    {
       public  String FarmName; //przechowuje nazwę naszej farmy
        public Form2(String farmName)
        {
            FarmName = farmName;
            InitializeComponent();
            textBoxFarmName.Text = FarmName;
        }

        private void buttonConfirmName_Click(object sender, EventArgs e)
        {
            FarmName = textBoxFarmName.Text;
            this.Hide();
            
        }
    }
}
