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
    public partial class TotalDiary : Form
    {
        string query; //string przechowujący zapytanie
        string connectionString = @"Data Source =LAPTOP-0QBN1NML\FRYGTT; database=FitApp; Trusted_Connection=yes"; //strin przechowujący adres bazy danych
        SqlConnection connection; //połączenie

        public TotalDiary()
        {
            InitializeComponent();
            FillMealsDiary();
            FillWorkoutDiary();
            GetSumKcalEaten();
            GetSumKcalBurned();
            TotalKcalSum();
            dataGridViewMeals.ReadOnly = true;
            dataGridViewMeals.Columns[0].Visible = false;
            dataGridViewMeals.Columns[1].Visible = false;
            dataGridViewMeals.RowHeadersVisible = false;

            dataGridViewWorkout.ReadOnly = true;
            dataGridViewWorkout.Columns[0].Visible = false;
            dataGridViewWorkout.Columns[1].Visible = false;
            dataGridViewWorkout.RowHeadersVisible = false;
        }

        /// <summary>
        /// wypełnia tabel posiłków dodanych do dziennika w wybranym dnu (data wybierana na datePickerze)
        /// </summary>
        void FillMealsDiary()
        {
            String date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
            query = "SELECT  MealsList.Id, Meals.Id, Meals.Name, Meals.Kcal FROM Meals " +
                    "INNER JOIN MealsList ON Meals.Id = MealsList.IdMeal " +
                    "WHERE MealsList.Date = @date; ";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapterFill = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@date", date);

                DataTable diaryTable = new DataTable();
                adapterFill.Fill(diaryTable);

                dataGridViewMeals.DataSource = diaryTable;
            }
        }
        /// <summary>
        /// wypełnia tabelę ćwiczeń dodanych do dziennika w wyranym dniu (data wybierana na datePickerze) 
        /// </summary>
        void FillWorkoutDiary()
        {
            String date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
            query = "SELECT WorkoutsList.Id, WorkoutsList.WorkoutId, Workouts.Name, Workouts.Kcal FROM Workouts " +
                    "INNER JOIN WorkoutsList ON Workouts.Id = WorkoutsList.WorkoutId " +
                    "WHERE WorkoutsList.Date = @date";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapterFill = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@date", date);

                DataTable diaryTable = new DataTable();
                adapterFill.Fill(diaryTable);

                dataGridViewWorkout.DataSource = diaryTable;
            }
        }
        /// <summary>
        /// button zatwierdzający zmianę daty i odświeżający interfejs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeDate_Click(object sender, EventArgs e)
        {
            FillMealsDiary();
            FillWorkoutDiary();
            GetSumKcalEaten();
            GetSumKcalBurned();
            TotalKcalSum();
        }
        /// <summary>
        /// sumuje Kcal ze wszystkich posiłków i wyświetla ich sumę w labelKcalEatenVal
        /// </summary>
        void GetSumKcalEaten()
        {
            String date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
            query = "SELECT SUM(Kcal) FROM Meals " +
                    "INNER JOIN MealsList ON Meals.Id = MealsList.IdMeal " +
                    "WHERE MealsList.Date = @date;";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapterFill = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@date", date);

                DataTable ingredientsTable = new DataTable();
                adapterFill.Fill(ingredientsTable);
                labelKcalEatenVal.Text = ingredientsTable.Rows[0][0].ToString();
            }
        }
        /// <summary>
        /// sumuje Kcal ze wszystkich posiłków i wyświetla ich sumę w labelKcalBurnedVal
        /// </summary>
        void GetSumKcalBurned()
        {
            String date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
            query = "SELECT SUM(Kcal) FROM Workouts " +
                    "INNER JOIN WorkoutsList ON Workouts.Id = WorkoutsList.WorkoutId " +
                    "WHERE WorkoutsList.Date = @date;";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapterFill = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@date", date);

                DataTable ingredientsTable = new DataTable();
                adapterFill.Fill(ingredientsTable);
                labelKcalBurnedVal.Text = ingredientsTable.Rows[0][0].ToString();
            }
        }
        /// <summary>
        /// odejmuje sumę spalonych kalori od zjedzonych kalorii i wyświetla ją w labelKcalTotal
        /// </summary>
        void TotalKcalSum()
        {
            float kcalEaten, kcalBurned, kcalTotal;
            if (float.TryParse(labelKcalEatenVal.Text, out kcalEaten) && float.TryParse(labelKcalBurnedVal.Text, out kcalBurned))
            {
                kcalTotal = kcalEaten - kcalBurned;
                labelKcalTotalVal.Text = kcalTotal.ToString();
            }
            else
            {
                labelKcalTotalVal.Text = "";
            }
        }
    }
}
