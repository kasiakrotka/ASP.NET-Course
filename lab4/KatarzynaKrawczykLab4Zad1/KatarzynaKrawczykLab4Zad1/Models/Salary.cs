using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatarzynaKrawczykLab4Zad1.Models
{
    public class Salary: Entity
    {
        [Required]
        public DateTime Date { get; set; } //data wynagrodzenia
        [Required]
        public double Value { get; set; } //wielkość wynagrodzenia
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; } //id pracownika któremu dano wynagrodzenie 
        public int EmployeeId { get; set; }


    }
}
