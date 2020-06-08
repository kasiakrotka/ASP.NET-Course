using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatarzynaKrawczykLab4Zad1.Models
{
    public class Employee: Entity
    {
        [Required]
        public string Name { get; set; } //imie pracownika
        [Required]
        public string Surname { get; set; } //nazwisko pracownika
        [Required]
        public string Nip { get; set; } //nip pracownika
        [Required]
        public string Position { get; set; } //stanowisko na którym pracuje
        [Required]
        public bool IndefinitePeriod  { get; set; } //okres zatrudnienia: 0 -nieokreślony , 1-określony 
        
    }
}
