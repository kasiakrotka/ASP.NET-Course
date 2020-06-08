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
    public partial class StartWindow : Form
    {
        GameWindow gameWindow;
        AboutBoxDescription aboutBox;

        public StartWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// rozpoczyna grę i pobiera imie gracza wpisane w text box
        /// nie rozpocznie gry jeśli w texboxie nie ma żadnego znaku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart(object sender, EventArgs e)
        {
            if (textBoxCharacterName.Text == "")
                MessageBox.Show("This is not a name!");
            else
            {
                gameWindow = new GameWindow(textBoxCharacterName.Text);
                gameWindow.ShowDialog();
            }
            
        }

        private void buttonAboutBox_Click(object sender, EventArgs e)
        {
            aboutBox = new AboutBoxDescription();
            aboutBox.ShowDialog();
        }
    }
}
