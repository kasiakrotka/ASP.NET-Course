using KatarzynaKrawczykLab4Zad1.Models;
using KatarzynaKrawczykLab4Zad1.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatarzynaKrawczykLab4Zad1
{

    public partial class SalariesWindow : Form
    {
        private readonly Models.AppContext context;
        public RWRepository<Employee> Employee;
        public RWRepository<Salary> Salary;

        public SalariesWindow()
        {
            InitializeComponent();
            context = new Models.AppContext();
            Employee = new RWRepository<Employee>(context);
            Salary = new RWRepository<Salary>(context);
            GetAllEmployeesToDataGridView();
            GetAllSalariesToDataGridView();
            dataGridViewEmployees.RowHeadersVisible = false;
            dataGridViewSalaries.Columns[0].Visible = false;
            dataGridViewSalaries.RowHeadersVisible = false;
        }
        /// <summary>
        /// pobiera wszystkeich pracowników z bazy danych i wstawia je do dataGridViewEmployees
        /// </summary>
        private void GetAllEmployeesToDataGridView()
        {
            dataGridViewEmployees.DataSource = Employee.GetAll().Select(
                x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Surname = x.Surname,
                    Position = x.Position
                }
                ).ToList();
        }
        /// <summary>
        /// pobiera wszystkie wynagrodzenia z bazy danych i wstawia je do dataGridViewSalaries
        /// </summary>
        private void GetAllSalariesToDataGridView()
        {
            dataGridViewSalaries.DataSource = Salary.GetAll().Select(
                x => new
                {
                    Id = x.Id,
                    Date = x.Date,
                    Value = x.Value,
                    EmployeeId = x.EmployeeId
                }
                ).ToList();
        }
        /// <summary>
        /// dodaje nowe wynagrodzenie do bazy danych 
        /// </summary>
        private void AddSalaryToDataBase()
        {
            double salary;
            if (dataGridViewEmployees.SelectedCells.Count > 0 && Double.TryParse(textBoxValue.Text, out salary))
            {
                int currentRowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
                int employeeId = Int32.Parse(dataGridViewEmployees[0, currentRowIndex].Value.ToString());
                Salary newSalary = new Salary();
                newSalary.Value = salary;
                newSalary.EmployeeId = employeeId;
                newSalary.Date = dateTimePickerDate.Value;
                Salary.Create(newSalary);
            }
        }
        /// <summary>
        /// wywołuje dodanie nowego wynagrodzenia do bazy danych 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddSalaryToDataBase();
            GetAllSalariesToDataGridView();
        }
        /// <summary>
        /// usuwa wynagrodzenie z bazy danych 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (dataGridViewSalaries.SelectedCells.Count > 0)
            {
                int currentRowIndex = dataGridViewSalaries.CurrentCell.RowIndex;
                int salaryId = Int32.Parse(dataGridViewSalaries[0, currentRowIndex].Value.ToString());
                Salary.Delete(Salary.GetById(salaryId));
                GetAllSalariesToDataGridView();
            }
        }

    }
}
