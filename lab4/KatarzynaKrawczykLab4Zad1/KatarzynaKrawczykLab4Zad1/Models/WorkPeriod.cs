using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatarzynaKrawczykLab4Zad1.Models
{
    public class WorkPeriod: Entity
    {
        [Required]
        public DateTime StartDate { get; set; } //data początku okresu zatrudnienia 
        [Required]
        public int PeriodInMonths { get; set; } //okres zatrudnienia w miesiącach 
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; } //id pracownika który jest zatrudniony na dany okres 
        public int EmployeeId { get; set; }

    }
}
