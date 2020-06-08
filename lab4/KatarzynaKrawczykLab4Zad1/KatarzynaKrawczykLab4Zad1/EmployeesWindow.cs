using iTextSharp.text;
using iTextSharp.text.pdf;
using KatarzynaKrawczykLab4Zad1.Models;
using KatarzynaKrawczykLab4Zad1.Repository;
using System;
using System.Data;
using System.IO;
using System.Linq;

using System.Windows.Forms;

namespace KatarzynaKrawczykLab4Zad1
{
    public partial class EmployeesWindow : Form
    {
        string companyName;
        private readonly Models.AppContext context;
        public RWRepository<Employee> Employee;
        public RWRepository<Salary> Salary;
        public RWRepository<WorkPeriod> WorkPeriod;

        public EmployeesWindow(string companyName)
        {
            InitializeComponent();
            context = new Models.AppContext();
            Employee = new RWRepository<Employee>(context);
            Salary = new RWRepository<Salary>(context);
            WorkPeriod = new RWRepository<WorkPeriod>(context);
            GetAllEmployeesToDataGridView();
            dataGridViewEmployees.Rows[0].Visible = false;
            this.companyName = companyName;
        }
        /// <summary>
        /// umieszcza dane o wszystkich pracownikach w dataGridViewEmployees
        /// </summary>
        private void GetAllEmployeesToDataGridView()
        {
            dataGridViewEmployees.DataSource = Employee.GetAll().Select(
                x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Surname = x.Surname,
                    Nip = x.Nip,
                    Position = x.Position,
                    IndefinitePeriod = x.IndefinitePeriod
                }
                ).ToList();
        }
        /// <summary>
        /// dodaje pracownika do bazy danych 
        /// </summary>
        private void AddEmployeeToDataBase()
        {
            //sprawdza czy wszystkie puste pola zostały wypełnione, jeśli nie wyskakuje messageBox
            if (!String.IsNullOrWhiteSpace(textBoxName.Text) && !String.IsNullOrWhiteSpace(textBoxSurname.Text) && !String.IsNullOrWhiteSpace(textBoxNip.Text) && !String.IsNullOrWhiteSpace(textBoxPosition.Text))
            {
                Employee employee = new Employee();
                employee.Name = textBoxName.Text;
                employee.Surname = textBoxSurname.Text;
                employee.Nip = textBoxNip.Text;
                employee.Position = textBoxPosition.Text;
                employee.IndefinitePeriod = checkBoxIndefinitePeriod.Checked;
                Employee.Create(employee);
            }
            else
                MessageBox.Show("Wypełnj puste pola przed dodaniem pracownika!", "Niepowodzenie", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //wywołuje dodanie pracownika do bazy danych i odświeża tabelę 
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeToDataBase();
            GetAllEmployeesToDataGridView();
        }
        //pobiera dane z dataGridView i wkleja je do textBoxów 
        private void buttonGetDataToTextBoxes_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedCells.Count > 0)
            {
                int currentRowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
                textBoxName.Text = dataGridViewEmployees[1, currentRowIndex].Value.ToString();
                textBoxSurname.Text = dataGridViewEmployees[2, currentRowIndex].Value.ToString();
                textBoxNip.Text = dataGridViewEmployees[3, currentRowIndex].Value.ToString();
                textBoxPosition.Text = dataGridViewEmployees[4, currentRowIndex].Value.ToString();
                checkBoxIndefinitePeriod.Checked = Convert.ToBoolean(dataGridViewEmployees[5, currentRowIndex].Value.ToString());
            }
        }
        //usuwa pracownika z bazy danych a wraz z nim wszystkie jego wypłaty oraz okres zatrudnienia 
        private void DeleteEmployee()
        {

            if (dataGridViewEmployees.SelectedCells.Count > 0)
            {
                int currentRowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
                int employeeId = Int32.Parse(dataGridViewEmployees[0, currentRowIndex].Value.ToString());

                Employee.Delete(Employee.GetById(employeeId));
                GetAllEmployeesToDataGridView();

                //usuwanie wypłat 
                foreach (Salary salary in Salary.GetAll().Where(x => x.EmployeeId == employeeId).ToList())
                    Salary.Delete(salary);
                //usuwanie okresu zatrudnienia (powinien być jeden ale na wszelki wypadek i tak napisałam tak jakby mogło być ich więcej 
                //choć przy edytowaniu bazy danych jedynie przez aplikacje nie powinno być to możliwe) 
                foreach (WorkPeriod workPeriod in WorkPeriod.GetAll().Where(x => x.EmployeeId == employeeId).ToList())
                    WorkPeriod.Delete(workPeriod);
            }
        }
        //wywołuje usuwanie zaznaczonego w tabeli pracownika 
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }
        //zwraca datę początku zatrudnienia zazcznaonego praconwika  
        private string GetDate()
        {
            if (dataGridViewEmployees.SelectedCells.Count > 0)
            {
                int currentRowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
                int employeeId = Int32.Parse(dataGridViewEmployees[0, currentRowIndex].Value.ToString());
                string date = WorkPeriod.GetAll().Where(x => x.EmployeeId == employeeId).Select(x => new { StartDate = x.StartDate }).Single().StartDate.ToString();
                return date.Substring(0, date.IndexOf(' '));
            }
            return "0";
        }
        /// <summary>
        /// zwraca ilość miesięcy na które zatrudniony jest zaznaczony pracownik 
        /// </summary>
        /// <returns></returns>
        private string GetMonths()
        {
            if (dataGridViewEmployees.SelectedCells.Count > 0)
            {
                int currentRowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
                int employeeId = Int32.Parse(dataGridViewEmployees[0, currentRowIndex].Value.ToString());
                string months = WorkPeriod.GetAll().Where(x => x.EmployeeId == employeeId).Select(x => new { PeriodInMonths = x.PeriodInMonths }).Single().PeriodInMonths.ToString();
                return months;
            }
            return "0";
        }
        /// <summary>
        /// zwraca średnie wynagrodzenie pracownika na podstawie ostatnich trzech miesięcy 
        /// </summary>
        /// <returns></returns>
        private string GetAvgSalary()
        {

            if (dataGridViewEmployees.SelectedCells.Count > 0)
            {
                int currentRowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
                int employeeId = Int32.Parse(dataGridViewEmployees[0, currentRowIndex].Value.ToString());
                int countSalaryRows = Salary.GetAll().Where(x => x.EmployeeId == employeeId).Select(x => new { Value = x.Value }).Count();
                if (countSalaryRows > 2)
                { return Math.Round(Salary.GetAll().Where(x => x.EmployeeId == employeeId).OrderBy(x => x.Date).Take(3).Select(x => new { Value = x.Value }).Average(x => x.Value), 2).ToString(); }
                else
                    if (countSalaryRows > 0)
                    return  Math.Round(Salary.GetAll().Where(x => x.EmployeeId == employeeId).OrderBy(x => x.Date).Take(countSalaryRows).Select(x => new { Value = x.Value }).Average(x => x.Value), 2).ToString();     
            }
            return "0";
        }
        /// <summary>
        /// generuje plik pdf "Zaświadczenia o pracy i zarobkach" dla zaznaczonego pracownika na podstawie danych z tabel 
        /// </summary>
        private void GeneratePdfFile()
        {

            if (dataGridViewEmployees.SelectedCells.Count > 0)
            {
                try
                {
                    int currentRowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
                    string fileName = dataGridViewEmployees[1, currentRowIndex].Value.ToString() + "_" + dataGridViewEmployees[2, currentRowIndex].Value.ToString() + ".pdf";
                    string date = GetDate();
                    string months = GetMonths();
                    Paragraph paragraph;
                    Chunk chunk;
                    FileStream fleStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);

                    //rozmiar dokumentu 
                    Rectangle rectangle = new Rectangle(PageSize.A5.Rotate()); 
                    Document doc = new Document(rectangle);

                    //czcionka i kodowanie
                    BaseFont bfTimes = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1257, BaseFont.EMBEDDED);
                    Font times = new Font(bfTimes, 10f);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fleStream);
                    doc.Open();
                    paragraph = new Paragraph(".........................,dnia...............", times);
                    paragraph.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(paragraph);
                    paragraph = new Paragraph(" (pieczęć nagłówkowa pracodawcy)", times);
                    paragraph.Alignment = Element.ALIGN_LEFT;
                    doc.Add(paragraph);
                    paragraph = new Paragraph(" \n ", times);
                    doc.Add(paragraph);
                    paragraph = new Paragraph(" ZAŚWIADCZENIE O ZATRUDNIENIU I ZAROBKACH ", times);
                    paragraph.Alignment = Element.ALIGN_CENTER;
                    doc.Add(paragraph);
                    paragraph = new Paragraph(" \n ", times);
                    doc.Add(paragraph);
                    paragraph = new Paragraph("Zaświadcza się, że Pan/Pani " + dataGridViewEmployees[1, currentRowIndex].Value.ToString() + " " + dataGridViewEmployees[2, currentRowIndex].Value.ToString(), times);
                    paragraph.Alignment = Element.ALIGN_LEFT;
                    doc.Add(paragraph);
                    paragraph = new Paragraph("legitymujący(a) się dowodem osobistym o numerze i serii " + dataGridViewEmployees[3, currentRowIndex].Value.ToString(), times);
                    doc.Add(paragraph);
                    paragraph = new Paragraph("jest zatrudniony(a) w " + companyName, times);
                    doc.Add(paragraph);
                    chunk = new Chunk(" na stanowisku " + dataGridViewEmployees[4, currentRowIndex].Value.ToString(), times);
                    doc.Add(chunk);
                    if (dataGridViewEmployees[5, currentRowIndex].Value.ToString().Equals("False"))
                    {
                        chunk = new Chunk(" na czas nieokreślony.", times);
                        doc.Add(chunk);
                    }
                    else
                    {
                        chunk = new Chunk(" na czas określony od dnia " +date+ " na czas " +months+ " miesęcy.", times);
                        doc.Add(chunk);
                    }
                    paragraph = new Paragraph("Przeciętne miesięczne wynagrodzenie brutto z minionego kwartału wynosi " + GetAvgSalary() + "zł i jest/nie jest obciążone sądowymi lub administracyjnymi tytułami egzekucyjnymi.", times);
                    doc.Add(paragraph);
                    paragraph = new Paragraph("\n", times);
                    doc.Add(paragraph);
                    paragraph = new Paragraph("Wyżej wymieniony(a) znajduje/nie znajduje się w okresie wypowiedzenia umowy o pracę. Zakład pracy znajduje/nie znajduje się w stanie likwidacji lub upadłości.", times);
                    doc.Add(paragraph);
                    doc.Close();
                    MessageBox.Show("Pdf został utworzony pod nazwą: "+fileName, "Powodzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Niepowodzenie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        ///wywołuje generowanie dokumentu pdf 
        private void buttonGenerateDocument_Click(object sender, EventArgs e)
        {
            GeneratePdfFile();
        }

        private void UpdateEmployee(int employeeId)
        {
            Employee existingEmployee = Employee.GetAll().Find(x => x.Id == employeeId);
            Employee newEmployee = existingEmployee;

            if (!String.IsNullOrWhiteSpace(textBoxName.Text) && !String.IsNullOrWhiteSpace(textBoxSurname.Text) && !String.IsNullOrWhiteSpace(textBoxNip.Text) && !String.IsNullOrWhiteSpace(textBoxPosition.Text))
            {
                newEmployee.Name = textBoxName.Text;
                newEmployee.Surname = textBoxSurname.Text;
                newEmployee.Nip = textBoxNip.Text;
                newEmployee.Position = textBoxPosition.Text;

                Employee.Update(newEmployee);
                MessageBox.Show("Aktualizacja wykonana oprawnie", "Powodzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("Wypełnj puste pola przed edycją pracownika!", "Niepowodzenie", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedCells.Count > 0)
            {
                int currentRowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
                int employeeId = Int32.Parse(dataGridViewEmployees[0, currentRowIndex].Value.ToString());
                UpdateEmployee(employeeId);

                GetAllEmployeesToDataGridView();
            }
        }
    }
}
