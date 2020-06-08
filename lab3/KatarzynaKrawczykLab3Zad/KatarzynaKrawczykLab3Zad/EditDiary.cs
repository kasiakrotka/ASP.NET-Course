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
    public partial class EditDiary : Form
    {
        string query; // string przechowujący zapytanie
        string connectionString = @"Data Source =LAPTOP-0QBN1NML\FRYGTT; database=FitApp; Trusted_Connection=yes"; //string przechowujący adres połączenia
        SqlConnection connection; //połączenie
        AddMeal addMeal; //okno z edycją bazy danych składnikow i posiłków 
        
        public EditDiary()
        {
            InitializeComponent();
            FillDiaryTable();
            FillMelasTable();
            
            dataGridViewMeals.ReadOnly = true;
            dataGridViewMeals.Columns[0].Visible = false;
            dataGridViewMeals.RowHeadersVisible = false;

            dateTimePickerDate.Value= DateTime.Now; 
            dataGridViewDiary.ReadOnly = true;
            dataGridViewDiary.Columns[0].Visible = false;
            dataGridViewDiary.Columns[1].Visible = false;
            dataGridViewDiary.RowHeadersVisible = false;
            dataGridViewIngredients.AllowUserToAddRows = false;
        }
        /// <summary>
        /// wypełnia tablice posiłków, posiłkami z bazy danych 
        /// </summary>
        private void FillMelasTable()
        {
            query = "SELECT * FROM Meals;";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapterFill = new SqlDataAdapter(query, connection))
            {
                DataTable mealTable = new DataTable();
                adapterFill.Fill(mealTable);
                dataGridViewMeals.DataSource = mealTable;
            }
        }
        /// <summary>
        /// wypełnia tablicę dziennika posiłkami które zostały spożyte w odpowiadający dniu (dzien wybierany na datePicker) 
        /// </summary>
        private void FillDiaryTable()
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

                dataGridViewDiary.DataSource = diaryTable;
            }

        }
        /// <summary>
        /// wyepłnia tablicę składników które są zawarte w wybranym posiłku w tabeli posiłków z bazy danych 
        /// </summary>
        private void FillIngredientsTable()
        {
            query = "SELECT Ingredients.* FROM Ingredients " +
                    "INNER JOIN MealIngredients ON Ingredients.Id = MealIngredients.IdIngredient " +
                    "WHERE MealIngredients.IdMeal = @idMeal; ";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapterFill = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@idMeal", dataGridViewMeals[0, dataGridViewMeals.CurrentRow.Index].Value.ToString());

                DataTable ingredientsTable = new DataTable();
                adapterFill.Fill(ingredientsTable);

                dataGridViewIngredients.DataSource = ingredientsTable;
            }

        }

        /// <summary>
        /// odświeża tablicę z dziennikiem posiłków dla danego dnia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeDate_Click(object sender, EventArgs e)
        {
            FillDiaryTable();
        }
        /// <summary>
        /// usuwa posiłek z dziennika posiłków 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM MealsList WHERE Id=@id";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", dataGridViewDiary[0, dataGridViewDiary.CurrentRow.Index].Value.ToString());
                command.ExecuteScalar();
            }
            FillDiaryTable();
        }
        /// <summary>
        /// dodaje posiłek do dziennika (w zadanej na datePicker dacie)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddToDiary_Click(object sender, EventArgs e)
        {
            String date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
            query = "INSERT INTO MealsList VALUES(@date, @idMeal)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@idMeal", dataGridViewMeals[0, dataGridViewMeals.CurrentRow.Index].Value.ToString());
                cmd.ExecuteNonQuery();
            }
            FillDiaryTable();
        }
        /// <summary>
        /// wyszukuje posiłek po zadanych kryteriach i wyświetla go w tabeli posiłków z bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (checkBoxVegan.Checked && checkBoxVegetarian.Checked)
                query = "SELECT * FROM Meals WHERE Vegetarian = 'true' AND Vegan = 'true' AND Name LIKE '%"+ textBoxMealName.Text + "%';";
            else
            {
                if (checkBoxVegetarian.Checked)
                    query = "SELECT * FROM Meals WHERE Vegetarian='true' AND Name LIKE '%" + textBoxMealName.Text + "%';";
                else
                    if (checkBoxVegan.Checked)
                        query = "SELECT * FROM Meals WHERE Vegan='true' AND Name LIKE '%" + textBoxMealName.Text + "%';";
                    else
                        query = "SELECT * FROM Meals WHERE Name LIKE '%" + textBoxMealName.Text + "%';";
            }
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapterFill = new SqlDataAdapter(query, connection))
            {
                DataTable mealTable = new DataTable();
                adapterFill.Fill(mealTable);
                dataGridViewMeals.DataSource = mealTable;
            }

        }
        /// <summary>
        /// otwiera okno edycji posiłków i składników oraz tworzenia nowych posiłków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditMealsAndIngredients_Click(object sender, EventArgs e)
        {
            addMeal = new AddMeal();
            addMeal.ShowDialog();
            FillDiaryTable();
            FillMelasTable();
        }
        /// <summary>
        /// odświeża tabelę ze składnikami posiłku przy każdym wybraniu innego posiłku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMeals_SelectionChanged(object sender, EventArgs e)
        {
            FillIngredientsTable();
        }
    }
}
