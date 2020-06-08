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
    public partial class GameWindow : Form
    {
        Enemy enemy; // obiekt reprezentujący przeciwnika
        Warrior player; // obiektreprezentujący gracza 
        int counter; //ile przeciwników zabito;
        int experience; //ile doświadczenia zdobył gracz
        int nextLevel; //ile doświaczenia jest potrzebne do noego levelu 
        string[] playerStats; //statystyki gracza zebrane do tablicy w kkolejności :damage, criticalChance, dodgeChance
        string[] enemyStats; //statystyki przeciwnika zebrane do tablicy w kkolejności :damage, criticalChance, dodgeChance
        Point labelEnemyTakenDamageLocation; //punkt przechowujący początkowe współżędne położenie labelEnemyTakenDamage
        Point labelPlayerTakenDamageLocaton; //punkt przechowujący początkowe współżędne położenie labelPlayerTakenDamage
        double damageTaken; //zadane obrażenia 
        bool getHit; //zmienna która przekazuje czy nastąpiło trafienie czy unik 

        public GameWindow(string characterName)
        {
            InitializeComponent();
            player = new Warrior(characterName);
            enemy = new Enemy();
            counter = 0;
            damageTaken = 0;
            getHit = false;
            experience = 0;
            nextLevel = 10;
            labelCharacterName.Text = characterName;
            labelEnemyHealthPoints.Text = enemy.HealthPoints.ToString();
            progressBarEnemyHealth.Maximum = enemy.HealthPoints;
            progressBarEnemyHealth.Value = progressBarEnemyHealth.Maximum;
            labelPlayerHealthPoints.Text = player.HealthPoints.ToString();
            progressBarPlayerHealth.Maximum = player.HealthPoints;
            progressBarPlayerHealth.Value = progressBarPlayerHealth.Maximum;
            labelEnemyTakenDamage.Hide();
            labelPlayerTakenDamage.Hide();
            playerStats = player.GetStats();
            labelPlayerDamageValue.Text = playerStats[0];
            labelPlayerCriticalValue.Text = playerStats[1];
            labelPlayerDodgeValue.Text = playerStats[2];
            enemyStats = enemy.GetStats();
            labelEnemyDamageValue.Text = enemyStats[0];
            labelEnemyCriticalValue.Text = enemyStats[1];
            labelEnemyDodgeValue.Text = enemyStats[2];
            labelEnemyTakenDamageLocation = new Point(labelEnemyTakenDamage.Location.X, labelEnemyTakenDamage.Location.Y);
            labelPlayerTakenDamageLocaton = new Point(labelPlayerTakenDamage.Location.X, labelPlayerTakenDamage.Location.Y);
            buttonNextBattle.Enabled = false;

            ///kod na przezroczyste tło zaczerpnięty z 
            ///https://stackoverflow.com/questions/4387680/transparent-background-on-winforms?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = BackColor;
        }

        /// <summary>
        /// wykonanie ruchu przez przeciwnika 
        /// </summary>
        private void EnemyMakeMove()
        {
            damageTaken = enemy.Hit();
            getHit = player.GetHit(damageTaken);
            if (getHit)// jeśli gracz nie zrobi uniku 
            {
                labelPlayerHealthPoints.Text = player.HealthPoints.ToString(); 
                labelPlayerTakenDamage.Text = "-" + Math.Round(damageTaken).ToString();
            }
            else//jeśli gracz zrobi unik 
            {
                labelPlayerTakenDamage.Text = "DODGE!";
            }
            labelPlayerTakenDamage.Show();      //wyświetlenie animacji poruszania labelPlayerTakenDamage
            timerPlayerLabelMoveTime.Start();
            timerPlayerLabelMove.Start();

            if (player.HealthPoints>0)//aktualizacja progressBarPlayerHealth
            {
                progressBarPlayerHealth.Value = player.HealthPoints;
            }
            else
            {
                progressBarPlayerHealth.Value = 0;
                MessageBox.Show("You died");
                buttonHit.Enabled=false;
                buttonNextBattle.Enabled = false;
                timerTurnPause.Stop();
            }
        }

        /// <summary>
        /// Kliknięcie rozpoczyna kolejną walkę. 
        /// Tworzy nowego wroga na miejsce starego i aktualizuje wyświetlane statystyki oraz pasek życia.
        /// Włącza ponownie button hit który zostaje wyłączony po zabicu poprzedniego przeciwnika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNextBattle_Click(object sender, EventArgs e)
        {
            enemy = new Enemy();
            buttonHit.Enabled = true;
            buttonNextBattle.Enabled = false; 
            enemyStats = enemy.GetStats();
            labelEnemyDamageValue.Text = enemyStats[0];
            labelEnemyCriticalValue.Text = enemyStats[1];
            labelEnemyDodgeValue.Text = enemyStats[2];
            labelEnemyHealthPoints.Text = enemy.HealthPoints.ToString();
            progressBarEnemyHealth.Maximum = enemy.HealthPoints;
            progressBarEnemyHealth.Value = progressBarEnemyHealth.Maximum;
        }

        /// <summary>
        /// po kliknięciu buttonHit wykonujemy ruch (bicie) oraz zmieniane są parametry wyświetlane na ekranie 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHit_Click(object sender, EventArgs e)
        {
            damageTaken =player.Hit(); 
            getHit = enemy.GetHit(damageTaken);
            if (getHit) //jeśli przeciwnik zostanie trafiony 
            {
                labelEnemyHealthPoints.Text = enemy.HealthPoints.ToString();
                labelEnemyTakenDamage.Text = "-" + Math.Round(damageTaken).ToString();
            }
            else //jeśli przeciwnik zrobi unik 
            {
                labelEnemyTakenDamage.Text = "DODGE!";
            }
            labelEnemyTakenDamage.Show();   //animacja labelEnemyTakenDamage
            timerEnemyLabelMoveTime.Start();
            timerEnemyLabelMove.Start();

            buttonHit.Enabled = false;  //wyłączenie przycisku hit na czas trwaniatury przeciwnika 

            if (enemy.HealthPoints > 0) //jeśli przeciwnik przeżyje
            {
                progressBarEnemyHealth.Value = enemy.HealthPoints;
                timerTurnPause.Start();

            }
            else //jeśli przeciwnik nie przeżyje ataku
            {
                buttonHit.Enabled = false;
                buttonNextBattle.Enabled = true;
                progressBarEnemyHealth.Value = 0;
                MessageBox.Show("You did it!");
                counter++;
                labelKilledValue.Text = counter.ToString();
                experience += enemy.ExperienceValue();

                //jeśli po zabiciu przeciwnika mamy wystarczająco doswiadczenia na level up 
                if(experience >= nextLevel)
                {
                    experience -= nextLevel;
                    nextLevel = nextLevel * 2;
                    player.LevelUp();
                    //aktualizacja statystyk
                    playerStats = player.GetStats(); 
                    labelPlayerDamageValue.Text = playerStats[0];
                    labelPlayerCriticalValue.Text = playerStats[1];
                    labelPlayerDodgeValue.Text = playerStats[2];
                    labelPlayerHealthPoints.Text = player.HealthPoints.ToString();
                    progressBarPlayerHealth.Maximum = player.HealthPoints;
                    progressBarPlayerHealth.Value = progressBarPlayerHealth.Maximum;
                }

                labelExperienceValue.Text = experience.ToString();
            }


        }
        /// <summary>
        /// timer który na czas ruchu przeciwnika zatrzymuje możliwości gracza na 1.5 sekduny dla uzyskania płynniejszego tempa rozgrywki. 
        /// Po wykonaniu ruchu przez przzeciwnika przywraca możliwości gracza. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTurnPause_Tick(object sender, EventArgs e)
        {
            EnemyMakeMove();
            buttonHit.Enabled = true;
            timerTurnPause.Stop();
        }
        /// <summary>
        /// porusza labelEnemyTakenDamage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEnemyLabelMove_Tick(object sender, EventArgs e)
        {
            labelEnemyTakenDamage.Top += -3;
        }
        /// <summary>
        /// wyznacza czas w którym labelEnemyTakenDamage się porusza i przywraca go na pierwiotne współrzędne 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEnemyLabelMoveTime_Tick(object sender, EventArgs e)
        {
            labelEnemyTakenDamage.Hide();
            labelEnemyTakenDamage.Location = labelEnemyTakenDamageLocation;
            timerEnemyLabelMove.Stop();
            timerEnemyLabelMoveTime.Stop();
        }
        /// <summary>
        /// porusza labelPlayerTakenDamage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPlayerLabelMove_Tick(object sender, EventArgs e)
        {
            labelPlayerTakenDamage.Top += -3;
        }
        /// <summary>
        /// wyznacza czas w którym labelPlayerTakenDamage się porusza i przywraca go na pierwiotne miejsce 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPlayerLabelMoveTime_Tick(object sender, EventArgs e)
        {
            labelPlayerTakenDamage.Hide();
            labelPlayerTakenDamage.Location = labelPlayerTakenDamageLocaton;
            timerPlayerLabelMove.Stop();
            timerPlayerLabelMoveTime.Stop();
        }


    }
}
