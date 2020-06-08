using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KatarzynaKrawczykLab3Zad
{
    public partial class Menu : Form
    {
        AddMeal addMealWindow; //okno edytujące bazę posiłków i składników
        WeightCalendar weightCalendar; //okno z dziennikiem wagi 
        EditDiary editDiary;    //okno edycji dziennika posiłków
        WorkoutDiary workoutDiary; //okno edycji dziennika ćwiczeń
        TotalDiary totalDiary; //okno podsumowujące dziennik posiłków i ćwiczeń 

        public Menu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// wywyołuje okno edycji bazy posiłków i składników 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMeal_Click(object sender, EventArgs e)
        {
            addMealWindow = new AddMeal();
            addMealWindow.ShowDialog();
        }
        /// <summary>
        /// wywołuje okno edycji dziennika wai 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddWeight_Click(object sender, EventArgs e)
        {
            weightCalendar = new WeightCalendar();
            weightCalendar.ShowDialog();
        }
        /// <summary>
        /// wywołuje okno edycji dziennika posiłków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddTodaysMeals_Click(object sender, EventArgs e)
        {
            editDiary = new EditDiary();
            editDiary.ShowDialog();
        }
        /// <summary>
        /// wywołuje okno eydycji dziennika ćwiczeń 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddExercises_Click(object sender, EventArgs e)
        {
            workoutDiary = new WorkoutDiary();
            workoutDiary.ShowDialog();
        }
        /// <summary>
        /// wywołuje okno podsmowujące dzienik posiłków i ćwiczeń
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSeeDiary_Click(object sender, EventArgs e)
        {
            totalDiary = new TotalDiary();
            totalDiary.ShowDialog();
        }
    }
}
