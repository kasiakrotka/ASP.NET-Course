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
    public partial class MainWindow : Form
    {
        string companyName; //nazwa firmy 
        EmployeesWindow employeesWindow; //okno ze spisem pracowników
        SalariesWindow salariesWindow; //okno ze spisem wynagrodzeń
        WorkPeriodWindow workPeriodWindow; //okno z okresami zatrudnienia 

        public MainWindow()
        {
            companyName = "Flat Design Company";
            InitializeComponent();
        }
        /// <summary>
        /// otwarcie okna ze spisem pracowników
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEmployeesList_Click(object sender, EventArgs e)
        {
            employeesWindow = new EmployeesWindow(companyName);
            employeesWindow.ShowDialog();
        }
        /// <summary>
        /// otwarcie okna ze spisem płac
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSalariesList_Click(object sender, EventArgs e)
        {
            salariesWindow = new SalariesWindow();
            salariesWindow.ShowDialog();
        }
        /// <summary>
        /// otwarcie okna ze spisem okresów zatrudnienia 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWorkPeriodList_Click(object sender, EventArgs e)
        {
            workPeriodWindow = new WorkPeriodWindow();
            workPeriodWindow.ShowDialog();
        }
    }
}
