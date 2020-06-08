using KatarzynaKrawczykLab4Zad1.Migrations;
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
    public partial class WorkPeriodWindow : Form
    {
        private readonly Models.AppContext context;
        public RWRepository<Employee> Employee;
        public RWRepository<WorkPeriod> WorkPeriod;

        public WorkPeriodWindow()
        {
            InitializeComponent();
            context = new Models.AppContext();
            Employee = new RWRepository<Employee>(context);
            WorkPeriod= new RWRepository<WorkPeriod>(context);
            GetAllEmployeesToDataGridView();
            GetAllWorkPeriodToDataGridView();
        }
        /// <summary>
        /// pobiera pracowników z bazy danych i wstawia ich do dataGridViewEmployees
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
        /// pobiera wszystkie okresy zatrudnienia z bazy danych i wstawia je do dataGRidViewWorkPeriod
        /// </summary>
        private void GetAllWorkPeriodToDataGridView()
        {
            dataGridViewWorkPeriod.DataSource = WorkPeriod.GetAll().Select(
                x => new
                {
                    Id = x.Id,
                    StartDate = x.StartDate,
                    EmployeeId = x.EmployeeId,
                    PeriodInMonths = x.PeriodInMonths,
                }
                ).ToList();
        }
       /// <summary>
       /// dodaje okres zatrudnienia do bazy danych 
       /// </summary>
       private void AddWorkPeriodToDataBase()
        {
            
            int periodInMonths;
            if (dataGridViewEmployees.SelectedCells.Count > 0 && Int32.TryParse(textBoxPeriodInMonths.Text, out periodInMonths))
            {
                int currentRowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
                int employeeId = Int32.Parse(dataGridViewEmployees[0, currentRowIndex].Value.ToString());

                if (WorkPeriod.GetAll().Where(x => x.EmployeeId == employeeId).Count() == 0)
                {
                    WorkPeriod newWorkPeriod = new WorkPeriod();
                    newWorkPeriod.PeriodInMonths = periodInMonths;
                    newWorkPeriod.EmployeeId = employeeId;
                    newWorkPeriod.StartDate = dateTimePickerDateStart.Value;
                    WorkPeriod.Create(newWorkPeriod);
                    //zmiana typu okresu zatrudnienia pracownika na określony 
                    ChangeIndefinitePeriodState(employeeId);
                }
                else
                    MessageBox.Show("Okres zatrudnienia dla tego pracownika został już wprowadzony", "Niepowodzenie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// zmienia typ zatrudnienia pracownika na przeciwny (nieokreślony, określony) 
        /// </summary>
        /// <param name="employeeId"></param>
        private void ChangeIndefinitePeriodState(int employeeId)
        {
            Employee existingEmployee = Employee.GetAll().Find(x => x.Id == employeeId);
            Employee newEmployee = existingEmployee;
            if (newEmployee.IndefinitePeriod == false)
                newEmployee.IndefinitePeriod = true;
            else
                newEmployee.IndefinitePeriod = false;
            Employee.Update(newEmployee);
            
        }
        /// <summary>
        /// usuwa okres zatrudnienia z bazy danych 
        /// </summary>
        private void DeleteWorkPeriodFromDatabase()
        {
            if (dataGridViewWorkPeriod.SelectedCells.Count > 0)
            {
                int currentEmployeeRowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
                int employeeId = Int32.Parse(dataGridViewEmployees[0, currentEmployeeRowIndex].Value.ToString());
                int currentWorkPeriodRowIndex = dataGridViewWorkPeriod.CurrentCell.RowIndex;
                int workPeriodId = Int32.Parse(dataGridViewWorkPeriod[0, currentWorkPeriodRowIndex].Value.ToString());
                WorkPeriod.Delete(WorkPeriod.GetById(workPeriodId));
                //zmienia typ zatrudnienia dla pracownika na "nieokreślony" 
                ChangeIndefinitePeriodState(employeeId);
            }
        }
        /// <summary>
        /// wywołuje dodanie okresu zatrudnienia do bazy danych 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddWorkPeriodToDataBase();
            GetAllWorkPeriodToDataGridView();
        }
        /// <summary>
        /// wywołuje usuniecie okresu zatrudnienia z bazy danych 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteWorkPeriodFromDatabase();
            GetAllWorkPeriodToDataGridView(); 
        }
    }
}
