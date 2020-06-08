using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace KatarzynaKrawczykLab2ZadDom
{
    abstract class Character 
    {
        protected string name; //nazwa postaci 
        protected int healthPoints; //punkty życia
        public int HealthPoints { get { return healthPoints; } private set { HealthPoints = healthPoints; } }//parametr zwracający i ustawiający punkty życia
        protected int maxDamage; //maksymalna siła ataku
        protected int minDamage; //minimalna sła ataku
        protected double accuracy; //celność 
        protected double criticalChance; //szansa trafienia krytycznego
        protected double dodgeChance; //szansa na unik
        SoundPlayer hitSound = new SoundPlayer("hitSound.wav"); //odgłos przy zadaniu ciosu 
        SoundPlayer dodgeSound = new SoundPlayer("dodgeSound.wav"); //odgłos przy uniku 
        protected Random random = new Random(); //klasa random potrzebna do obliczeń w funkcji Hit();

        public Character()
        { }

        public Character(string name)
        { this.name = name;}

        /// <summary>
        /// tworzy tablicę string zawierając podstawowe statystyki bohatera
        /// </summary>
        /// <returns></returns>
        public string[] GetStats()
        {
            string[] stats = new string[3];
            stats[0] = minDamage.ToString() + " - " + maxDamage.ToString();
            stats[1] = criticalChance.ToString() + "%";
            stats[2] = dodgeChance.ToString() + "%";

            return stats;
        }
        /// <summary>
        /// Losuje true lub false z zadanym prawdopodobieństwem dla true(false jest dopelnieniem, gdzie P(false)+P(true)=1)
        /// </summary>
        /// <param name="propability"></param>
        /// <returns></returns>
        protected bool CheckIfTrue(double propability)
        {
            Random random = new Random();
            if (random.NextDouble() < propability)
                return true;
            else
                return false;
        }

        /// <summary>
        /// funkcja dzięki której bohater zadaje cios
        /// </summary>
        /// <returns></returns>
        virtual public double Hit()
        {
            if (CheckIfTrue(criticalChance))
                return maxDamage;
            else
                return Convert.ToDouble(random.Next(minDamage, maxDamage - 1)) * accuracy;
        }
        /// <summary>
        /// funkcja dzięki któej bohater otrzymuje obrażenia 
        /// </summary>
        /// <param name="damage"></param>
        /// <returns></returns>
        virtual public bool GetHit(double damage)
        {   
            if (CheckIfTrue(dodgeChance))
            {
                dodgeSound.Play();
                return false;
            }

            else
            {
                hitSound.Play();
                healthPoints -= Convert.ToInt32(Math.Round(damage));
                return true;
            }
        }
    }
}
