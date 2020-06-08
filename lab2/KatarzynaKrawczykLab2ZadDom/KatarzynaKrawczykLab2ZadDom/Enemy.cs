using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatarzynaKrawczykLab2ZadDom
{
    class Enemy:Character, IBasicFightAction
    {
        
        public Enemy()
        {
            name = "Bad Man";
            healthPoints = random.Next(20, 30);
            maxDamage = random.Next(2, 10);
            minDamage = random.Next(1, maxDamage - 1);
            accuracy = Convert.ToDouble(random.Next(50, 100))/ 100;
            criticalChance = Convert.ToDouble(random.Next(10, 15))/ 100;
            dodgeChance = Convert.ToDouble(random.Next(1, 10))/ 100;
        }

        /// <summary>
        /// zwraca wartość doswiadczenia jakie można otrzymać za zabicie tego wroga
        /// </summary>
        /// <returns></returns>
        public int ExperienceValue()
        {
            return Convert.ToInt32(Math.Floor(maxDamage *accuracy));
        }
    }
}
