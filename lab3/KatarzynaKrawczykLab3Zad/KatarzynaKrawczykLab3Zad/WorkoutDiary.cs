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
    public partial class WorkoutDiary : Form
    {
        string query; //string zawierający zapytanie
        string connectionString = @"Data Source =LAPTOP-0QBN1NML\FRYGTT; database=FitApp; Trusted_Connection=yes"; //string zawierający adres bazy danych
        SqlConnection connection; //połączenie

        public WorkoutDiary()
        {
            InitializeComponent();
            FillWorkoutTable(); //wypełnienie tabeli ćwiczeń
            FillWorkoutTableDiary(); //wypełnienie tabeli dziennika
            dataGridViewWorkoutDiary.ReadOnly = true;
            dataGridViewWorkoutDiary.Columns[0].Visible = false;
            dataGridViewWorkoutDiary.Columns[1].Visible = false;
            dataGridViewWorkoutDiary.RowHeadersVisible = false;

            dataGridViewWorkoutTable.ReadOnly = true;
            dataGridViewWorkoutTable.Columns[0].Visible = false;
            dataGridViewWorkoutTable.RowHeadersVisible = false;
        }
        /// <summary>
        /// wypełnia tabelę ćwiczeniami z bazy danych
        /// </summary>
        void FillWorkoutTable()
        {
            query = "SELECT * FROM Workouts;";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapterFill = new SqlDataAdapter(query, connection))
            {
                DataTable workoutTable = new DataTable();
                adapterFill.Fill(workoutTable);
                dataGridViewWorkoutTable.DataSource = workoutTable;
            }
        }
        /// <summary>
        /// wypełnia tabelę ćwiczeniami w wybranym dniu 
        /// </summary>
         void FillWorkoutTableDiary()
        {
            String date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
            query = "SELECT WorkoutsList.Id, WorkoutsList.WorkoutId, Workouts.Name, Workouts.Kcal FROM Workouts "+
                    "INNER JOIN WorkoutsList ON Workouts.Id = WorkoutsList.WorkoutId "+
                    "WHERE WorkoutsList.Date = @date";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapterFill = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@date", date);

                DataTable diaryTable = new DataTable();
                adapterFill.Fill(diaryTable);

                dataGridViewWorkoutDiary.DataSource = diaryTable;
            }
        }
        /// <summary>
        /// potwierdzenie zmiany daty na datepickerze i wyświetlenie ćwiczeń wykonanych w wybranym dniu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeDate_Click(object sender, EventArgs e)
        {
            FillWorkoutTableDiary();
        }
        /// <summary>
        /// dodaje wybrane ćwiczenie z bazy danych do dziennika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddToDiary_Click(object sender, EventArgs e)
        {
            String date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
            query = "INSERT INTO WorkoutsList VALUES(@date, @idWorkout)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@idWorkout", dataGridViewWorkoutTable[0, dataGridViewWorkoutTable.CurrentRow.Index].Value.ToString());
                cmd.ExecuteNonQuery();
            }
            FillWorkoutTableDiary();
        }
        /// <summary>
        /// usuwa wybrane ćwiczenie z bazy danych 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteWorkot_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM WorkoutsList WHERE WorkoutId=@id";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", dataGridViewWorkoutTable[0, dataGridViewWorkoutTable.CurrentRow.Index].Value.ToString());
                command.ExecuteScalar();
            }
            FillWorkoutTableDiary();

            query = "DELETE FROM Workouts WHERE Id=@id";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", dataGridViewWorkoutTable[0, dataGridViewWorkoutTable.CurrentRow.Index].Value.ToString());
                command.ExecuteScalar();
            }
            FillWorkoutTable();
        }

        /// <summary>
        /// usuwa wybrane ćwiczenie z dziennika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteFromDiary_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM WorkoutsList WHERE Id=@id";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", dataGridViewWorkoutDiary[0, dataGridViewWorkoutDiary.CurrentRow.Index].Value.ToString());
                command.ExecuteScalar();
            }
            FillWorkoutTableDiary();
        }
        /// <summary>
        /// dodaje nowe ćwiczenie do bazy danych 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNewWorkout_Click(object sender, EventArgs e)
        {
            int m;
            float n;
            if (!String.IsNullOrEmpty(textBoxWorkoutName.Text) && int.TryParse(textBoxWorkoutTime.Text, out m) && float.TryParse(textBoxWorkoutKcal.Text, out n))
            {
                query = $"INSERT INTO Workouts VALUES(@name, @time, @kcal)";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@name", textBoxWorkoutName.Text);
                    cmd.Parameters.AddWithValue("@time", textBoxWorkoutTime.Text);
                    cmd.Parameters.AddWithValue("@kcal", textBoxWorkoutKcal.Text);


                    cmd.ExecuteNonQuery();
                }
                FillWorkoutTable();
            }
        }
    }
}
