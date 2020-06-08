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
    public partial class AddMeal : Form
    {
        string query; //string zawierający zapytanie
        string connectionString= @"Data Source =LAPTOP-0QBN1NML\FRYGTT; database=FitApp; Trusted_Connection=yes"; //string zawięrajacy adres
        SqlConnection connection; //połączenie 

        public AddMeal()
        {
            InitializeComponent();
            dataGridViewMeals.ReadOnly = true;
            FillMealTable();
            dataGridViewMeals.Columns[0].Visible = false;
            dataGridViewMeals.RowHeadersVisible = false;
            dataGridViewMeals.ReadOnly = true;
            FillIngredientTable();
            dataGridViewIngredients.Columns[0].Visible = false;
            dataGridViewIngredients.RowHeadersVisible = false;
            dataGridViewIngredients.ReadOnly = true;

        }
        /// <summary>
        /// wyepłnia tabelę posiłków wszystkimi posiłkami z bazy 
        /// </summary>
        private void FillMealTable()
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
        /// wypełnia tabelę składników, wszystkimi składnikami z bazy 
        /// </summary>
        private void FillIngredientTable()
        {
            query = "SELECT * FROM Ingredients;";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapterFill = new SqlDataAdapter(query, connection))
            {
                DataTable ingredientsTable = new DataTable();
                adapterFill.Fill(ingredientsTable);
                dataGridViewIngredients.DataSource = ingredientsTable;
            }
        }
        /// <summary>
        /// Dodaje posiłek do bazy posiłków (nazwe, czy vegetarianskie, czy veganskie, i kcal) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMeal_Click(object sender, EventArgs e)
        {
            query = $"INSERT INTO Meals VALUES(@name, @vegetarian, @vegan, @kcal)";
            using(connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                cmd.Parameters.AddWithValue("@name", textBoxMealName.Text); //przypisanie wartości z odpowiednich textboxów
                cmd.Parameters.AddWithValue("@vegetarian", checkBoxVegetarian.Checked.ToString());
                cmd.Parameters.AddWithValue("@vegan", checkBoxVegan.Checked.ToString());
                cmd.Parameters.AddWithValue("@kcal", "0");
                cmd.ExecuteNonQuery();
            }
            FillMealTable();
        }
        /// <summary>
        /// zmienia nazwe wybranego w tabeli posiłku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditMealName_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxMealName.Text)) //nie wkonuje operacji jeśli textbox jest pusty
            {
                query = "UPDATE Meals SET Name = @mealName WHERE Id=@mealId";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@mealName", textBoxMealName.Text);
                    command.Parameters.AddWithValue("@mealId", dataGridViewMeals[0, dataGridViewMeals.CurrentRow.Index].Value.ToString());
                    command.ExecuteScalar();
                }
                FillMealTable();
            }
        }
        /// <summary>
        /// dodaje składnik do bazy składników na podstawie wypełnienionych textboxów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            double n;//zminna do przypisania wartości
            //nie wykonuje operacji jśłi zmienne nie są możliwe do przekonwertowania na typ float
            if (!String.IsNullOrEmpty(textBoxIngredientName.Text) && double.TryParse(textBoxKcal.Text, out n) && double.TryParse(textBoxProetins.Text, out n) && double.TryParse(textBoxFat.Text, out n) && double.TryParse(textBoxCarbs.Text, out n) && double.TryParse(textBoxWeight.Text , out n))
            {
                query = $"INSERT INTO Ingredients VALUES(@name, @kcal, @protein, @fats, @carbs, @weight)";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@name", textBoxIngredientName.Text); //przypisanie wartości z odpowiednich textboxów
                    cmd.Parameters.AddWithValue("@kcal", double.Parse(textBoxKcal.Text));
                    cmd.Parameters.AddWithValue("@protein", double.Parse(textBoxProetins.Text));
                    cmd.Parameters.AddWithValue("@fats", double.Parse(textBoxFat.Text));
                    cmd.Parameters.AddWithValue("@carbs", double.Parse(textBoxCarbs.Text));
                    cmd.Parameters.AddWithValue("@weight", double.Parse(textBoxWeight.Text));

                    cmd.ExecuteNonQuery();
                }
                FillIngredientTable();
            }
        }
        /// <summary>
        /// wypłnia tabelę zawierającą składniki wybranego posiłku z tabeli posiłków oraz aktualizuje kaloryczność posiłku na podstawie zawartych skladników
        /// </summary>
        private void FillIngredientsOfMeal()
        {
            //wpisuje do tabeli Ingredients, składniki wybranego posiłku 
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

                dataGridViewIngredientsOfMeal.DataSource = ingredientsTable;
            }

            //sumuje wszystkie kalorie składników i wpisuje je do label
            query= "SELECT SUM(Kcal) FROM Ingredients "+
                    "INNER JOIN MealIngredients ON Ingredients.Id = MealIngredients.IdIngredient "+
                    "WHERE MealIngredients.IdMeal = @idMeal;";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapterFill = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@idMeal", dataGridViewMeals[0, dataGridViewMeals.CurrentRow.Index].Value.ToString());

                DataTable ingredientsTable = new DataTable();
                adapterFill.Fill(ingredientsTable);
                labelTotalKcalValue.Text =ingredientsTable.Rows[0][0].ToString();
                
            }

        }
        /// <summary>
        /// dodaje składnk z tabeli składników do wybranego posiłku z tabeli posiłki 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddInredientToMeal_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO MealIngredients (IdMeal, IdIngredient) VALUES (@idMeal,@idIngredient)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                cmd.Parameters.AddWithValue("@idMeal", dataGridViewMeals[0, dataGridViewMeals.CurrentRow.Index].Value.ToString());
                cmd.Parameters.AddWithValue("idIngredient", dataGridViewIngredients[0, dataGridViewIngredients.CurrentRow.Index].Value.ToString());
                cmd.ExecuteNonQuery();
            }
            FillIngredientsOfMeal();
        }
        /// <summary>
        /// aktualizuje wyświetlane składniki dla wybranego posiłku przy każdej zmianie wybranego wiersza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMeals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillIngredientsOfMeal();

            query = "UPDATE Meals SET Kcal=@kcal " +
            "WHERE Id = @idMeal;";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@kcal", labelTotalKcalValue.Text);
                command.Parameters.AddWithValue("@idMeal", dataGridViewMeals[0, dataGridViewMeals.CurrentRow.Index].Value.ToString());
                command.ExecuteScalar();
            }
        }
        /// <summary>
        /// usuwa składnik z bazy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteIngredient_Click(object sender, EventArgs e)
        {
            //usuwa usuwa pozycje z tabeli MealIngredients w których wystąpił dany składnik 
            query = "DELETE FROM MealIngredients WHERE IdIngredient=@id";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", dataGridViewIngredients[0, dataGridViewIngredients.CurrentRow.Index].Value.ToString());
                command.ExecuteScalar();
            }
            //usuwa wybrany składnik z bazy składników 
            query = "DELETE FROM Ingredients WHERE Id=@id";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", dataGridViewIngredients[0, dataGridViewIngredients.CurrentRow.Index].Value.ToString());
                command.ExecuteScalar();
            }
            FillIngredientsOfMeal();
            FillIngredientTable();
        }
        /// <summary>
        /// usuwa posiłek z bazy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteMeal_Click(object sender, EventArgs e)
        {
            //usuwa pozycje z tabeli MealsList w tórych wystąpił wybrany posiłek 
            query = "DELETE FROM MealsList WHERE IdMeal=@id";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", dataGridViewMeals[0, dataGridViewMeals.CurrentRow.Index].Value.ToString());
                command.ExecuteScalar();
            }
            //usuwa pozycje z tabeli MealIngredients w których wystąpił wybrany posiłek 
            query = "DELETE FROM MealIngredients WHERE IdMeal=@id";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", dataGridViewMeals[0, dataGridViewMeals.CurrentRow.Index].Value.ToString());
                command.ExecuteScalar();
            }
            //
            query = "DELETE FROM Meals WHERE Id=@id";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", dataGridViewMeals[0, dataGridViewMeals.CurrentRow.Index].Value.ToString());
                command.ExecuteScalar();
            }
            FillMealTable();
            FillIngredientsOfMeal();
        }
        /// <summary>
        /// usuwa składnik z wybranego posłku 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteIngredientFromMeal_Click(object sender, EventArgs e)
        {
            if (dataGridViewIngredientsOfMeal.Rows.Count  > 1)
            {
                query = "DELETE FROM MealIngredients WHERE IdMeal=@idMeal AND IdIngredient=@idIngredient";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@idMeal", dataGridViewMeals[0, dataGridViewMeals.CurrentRow.Index].Value.ToString());
                    command.Parameters.AddWithValue("@idIngredient", dataGridViewIngredientsOfMeal[0, dataGridViewIngredientsOfMeal.CurrentRow.Index].Value.ToString());
                    command.ExecuteScalar();
                }
                FillIngredientsOfMeal();
            }
        }
        /// <summary>
        /// przeladowuje tablice posiłki dzięki czemu jest w niej widoczna nowa wartość kcal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReload_Click(object sender, EventArgs e)
        {
            FillMealTable();
        }
    }
}
