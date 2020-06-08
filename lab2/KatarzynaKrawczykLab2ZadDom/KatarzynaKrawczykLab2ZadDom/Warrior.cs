using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatarzynaKrawczykLab2ZadDom
{
    class Warrior : Character, IBasicFightAction, ILevelUpSystem
    {
        /// <summary>
        /// zmmienna przetrzymującą początkową liczbę punktów życia na każdym levelu
        /// </summary>
        int healthPointsBasic;
        LevelUpWindow levelUpWindow;
        /// <summary>
        /// statystyki zadane a poczatek gry 
        /// </summary>
        /// <param name="userName"></param>
        public Warrior(string userName) 
        {
            name = userName;
            healthPoints=100;
            healthPointsBasic = 100;
            maxDamage = 10;
            minDamage = 1;
            accuracy = 0.60;
            criticalChance = 0.05; 
            dodgeChance = 0.10;
        }
        /// <summary>
        /// funkcja otwierajaco okienko z wyborem podniesienia statystyki w przypadku podniesieniu się levelu bohatera. 
        /// </summary>
        public void LevelUp()
        {
            healthPointsBasic += 10;
            healthPoints = healthPointsBasic;
            levelUpWindow = new LevelUpWindow();
            levelUpWindow.ShowDialog();
            switch(levelUpWindow.Choice)
            {
                case 1:
                        maxDamage += 2;
                        minDamage += 2;
                        break;
                case 2:
                    criticalChance += 0.01;
                    break;
                case 3:
                    dodgeChance += 0.02;
                    break;
                default:
                    break;
            }

        }
    }
}
