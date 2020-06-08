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
    public partial class Form1 : Form
    {
        int sheep, money, wool; // zmienne przechowujące ilość owiec, pieniędzy, jednostek wełny 
        int power;  // zmienna określająca moc przycisku buttonCut
        int magicScissorsCount; // zmienna określająca ilość posiadanych Magic Scissors
        int vitaminsCount; // ilosc zakupionych witamin
        int WoolPrice;  // ilość dolarów którą dostaniey za jedną jednostkę wełny
        int ScissorsPrice; // cena zwykłych nożyc 
        int MagicScissorsPrice; // cena magicznych nożyc 
        int SheepPrice; // cena jednej owcy 
        int VitaminsPrice; // cena witamin 
        String farmName; // okienko w którym zmieniamy nzwe farmy 

        public Form1()
        {
            InitializeComponent();
            sheep = 1;
            money = 0;
            wool = 0;
            power = 1;
            magicScissorsCount = 0;
            vitaminsCount = 0;
            WoolPrice = 1;
            ScissorsPrice = 75;
            MagicScissorsPrice = 450;
            SheepPrice = 100;
            VitaminsPrice = 150;
            farmName = "My Farm";
            textBoxFarmName.Text = farmName;
            labelScissorsPrice.Text = ScissorsPrice.ToString() + "$";
            labelMagicScissorsPrice.Text = MagicScissorsPrice.ToString() + "$";
            labelSheepPrice.Text = SheepPrice.ToString() + "$";
            labelVitaminsPrice.Text = VitaminsPrice.ToString() + " $";
            labelWoolPriceVal.Text = WoolPrice.ToString() + " $";
            labelScissorsCount.Text = power.ToString();
            labelMagicScissorsCount.Text = magicScissorsCount.ToString();
            buttonBuyScissors.Visible = false;
            buttonBuySheep.Visible = false;
            buttonBuyMagicScissors.Visible = false;
            buttonBuyVitamins.Visible = false;
            labelAchievBusinessman.Hide();
            labelAchievNurse.Hide();
            labelAchievShepard.Hide();
            labelAchievWitch.Hide();
            labelSheepsVal.Text = sheep.ToString();
            timerWool.Start();
            timerUpdate.Start();
            

        }

        private void buttonBuyScissors_Click(object sender, EventArgs e) ///przeza zakup nożyc zwiększa moc buttonCut oraz odejmuje ich cenę od aktualnie posiadanych pieniędzy.
        {
            if (money >= ScissorsPrice)
            {
                power++;
                money = money - ScissorsPrice;
                ScissorsPrice = ScissorsPrice + 50;
                labelScissorsPrice.Text = ScissorsPrice.ToString() + " $";  /// aktualizacja interfejsu
                labelScissorsCount.Text = power.ToString();
            }
        }

        private void buttonCut_Click(object sender, EventArgs e) /// pobiera odpowiednią ilość wełny i zamieniana na odpowiadającą ilość dolarów
        {
            if (wool >= power)   ///działa jedynie w przypadku gdy jesteśmy w stanie ściąć wełnę w przeciwnym wyświetli okno iformujące o braku zasobu 
            {
                wool = wool - power;
                money = money + WoolPrice*power;
                labelWoolVal.Text = wool.ToString();            /// aktualizacja interfejsu 
                labelMoneyVal.Text = money.ToString() + " $"; 
            }
            else
            {
                MessageBox.Show("You don't have wool!");
            }
        }

        private void buttonBuySheep_Click(object sender, EventArgs e)   /// pozwala na zakupienie nowej owcy oraz zwiększa cenę następnej
        {
            if (money >= SheepPrice)
            {
                sheep++;
                money = money - SheepPrice;
                SheepPrice = SheepPrice + 100;
                labelSheepPrice.Text = SheepPrice.ToString() + " $";    ///aktualizacja interfejsu
                labelSheepsVal.Text = sheep.ToString();
            }
        }

        private void buttonBuyMagicScissors_Click(object sender, EventArgs e)   /// pozwala na zakup magicznych nożyc które same tną wełnę
        {
            if (money >= MagicScissorsPrice)
            {
                magicScissorsCount++;
                money = money - MagicScissorsPrice;
                MagicScissorsPrice = MagicScissorsPrice * 3;
                labelMagicScissorsPrice.Text = MagicScissorsPrice.ToString() + " $";    ///aktualizacja interfejsu
                labelMagicScissorsCount.Text = magicScissorsCount.ToString();
            }
            
        }

        private void buttonBuyVitamins_Click(object sender, EventArgs e) // zmienia cenę wełny, odejmuje cnę witamin od funduszy i aktualizuje interfejs
        {
            if (money >= VitaminsPrice)
            {
                WoolPrice = WoolPrice + 2;
                money = money - VitaminsPrice;
                VitaminsPrice = VitaminsPrice * 2 + 100;
                labelVitaminsPrice.Text = VitaminsPrice.ToString() + " $";
                labelWoolPriceVal.Text = WoolPrice.ToString() + " $";
            }
                       
        }

        private void timerMagicPower_Tick(object sender, EventArgs e)   ///timer który w odpowiednim odstępie czasu automatycznie ścina wełnę 
        {
            if (wool >= magicScissorsCount*power)
            {
                for (int i = 0; i< magicScissorsCount; i++)
                {
                    wool = wool - power;
                    money = money + WoolPrice;
                    labelWoolVal.Text = wool.ToString();
                    labelMoneyVal.Text = money.ToString() + " $";
                }
            }
        }

        private void buttonChangeFarmName_Click(object sender, EventArgs e) // otwiera okno ze zmianą nazwy farmy i zmieniajej nazwe
        {
            Form2 farmNameForm = new Form2(farmName);
            farmNameForm.ShowDialog();
            farmName = farmNameForm.FarmName;
            textBoxFarmName.Text = farmName;

        }


        private void timerUpdate_Tick(object sender, EventArgs e) /* timer sprawdzający czy użytkownik ma odpowiednią ilośc pieniędzy 
                                                                    na zakup przedmiotów ze sklepu, aktualizuje interfejs i rozpoczyzna timer działania magicznch nożyc jeśli zostały zakupione. */
        {
            if (money >= ScissorsPrice)
                buttonBuyScissors.Visible = true;
            else
                buttonBuyScissors.Visible = false;

            if (money >= SheepPrice)
                buttonBuySheep.Visible = true;
            else
                buttonBuySheep.Visible = false;

            if (money >= MagicScissorsPrice)
                buttonBuyMagicScissors.Visible = true;
            else
                buttonBuyMagicScissors.Visible = false;

            if (money >= VitaminsPrice)
                buttonBuyVitamins.Visible = true;
            else
                buttonBuyVitamins.Visible = false;

            if (magicScissorsCount==1)
                timerMagicPower.Start();

            labelMoneyVal.Text = money.ToString()+" $";

            if(money>=1000)                         ///sprawdzanie czy warunki do osiągnięć zostały spełnione i wyświetlanie ich jeśli tak
                labelAchievBusinessman.Show();
            if(vitaminsCount == 10)
                labelAchievNurse.Show();
            if(sheep == 15)
                labelAchievShepard.Show();
            if(magicScissorsCount==5)
                labelAchievWitch.Show();


        }

        private void timerWool_Tick(object sender, EventArgs e) // dodaje kolejne jednotski wełny w zależności od ilości owiec i modulatorów. 
        {
            wool = wool + sheep;
            labelWoolVal.Text = wool.ToString();
        }

    }
}
