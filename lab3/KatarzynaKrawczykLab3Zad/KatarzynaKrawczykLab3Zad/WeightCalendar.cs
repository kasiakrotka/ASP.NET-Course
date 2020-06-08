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
    public partial class WeightCalendar : Form
    {
        String query;
        SqlConnection connection;
        string connectionString = @"Data Source =LAPTOP-0QBN1NML\FRYGTT; database=FitApp; Trusted_Connection=yes";

        public WeightCalendar()
        {
            InitializeComponent();
            FillWeightTable();
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.CustomFormat = "dddd - dd/MMM/yyyyy";
            dataGridViewWeight.ForeColor = Color.Black;
            dataGridViewWeight.Columns[0].Visible = false;
            dataGridViewWeight.Sort(dataGridViewWeight.Columns[1], ListSortDirection.Ascending);
            //dateTimePickerDate.CustomFormat="yyyy-MM-dd";
            //dateTimePickerDate=Datetimepickercu
        }
        /// <summary>
        /// wypełnia tabelę z wagami danymi z bazy danych 
        /// </summary>
        private void FillWeightTable()
        {
            query = "SELECT * FROM Progress ORDER BY Date;";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapterFill = new SqlDataAdapter(query, connection))
            {
                DataTable weightTable = new DataTable();
                adapterFill.Fill(weightTable);
                dataGridViewWeight.DataSource = weightTable;
            }

        }
        private void buttonTodayDate_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = DateTime.Now;
        }
        /// <summary>
        /// dodaje wagę w wybranej dacie do tabeli 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddWeight_Click(object sender, EventArgs e)
        {
            String date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
            query = $"INSERT INTO Progress VALUES(@date, @weight)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@weight", textBoxWeight.Text);
                cmd.ExecuteNonQuery();
            }
            FillWeightTable();
        }
        /// <summary>
        /// edytuję waę w zaznaczonym dniu w tabeli 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            query = "UPDATE Progress SET Weight = @weight WHERE Id=@dateId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@weight", textBoxWeight.Text);
                command.Parameters.AddWithValue("@dateId", dataGridViewWeight[0, dataGridViewWeight.CurrentRow.Index].Value.ToString());
                command.ExecuteScalar();
            }
            FillWeightTable();
        }
        /// <summary>
        /// usuwa zaznaczoną pozycję z tabeli 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM Progress WHERE Id=@dateId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@dateId", dataGridViewWeight[0, dataGridViewWeight.CurrentRow.Index].Value.ToString());
                command.ExecuteScalar();
            }
            FillWeightTable();
        }
    }
}
