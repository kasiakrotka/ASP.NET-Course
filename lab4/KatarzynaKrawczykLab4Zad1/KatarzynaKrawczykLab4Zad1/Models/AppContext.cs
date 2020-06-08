using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatarzynaKrawczykLab4Zad1.Models
{
    public class AppContext: DbContext

    {
        public AppContext(): base("AppContext")
        { }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<WorkPeriod> WorkPeriod { get; set; }
    }

}
