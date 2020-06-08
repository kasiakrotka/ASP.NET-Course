using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatarzynaKrawczykLab4Zad1.Models
{
    public abstract class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //klucz główny
        public int Id { get; set; }
    }
}
