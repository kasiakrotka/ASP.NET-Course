using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KatarzynaKrawczykLab6Zad1.Models
{
    //model zestawu ocen
    public class GradeModel
    {
        public int Id { get; set; } //id zestawu

        public string Album { get; set; } //nr albumu

        public decimal? FirstTestPoints { get; set; } //punkty z pierwszego testu 

        public decimal? SecondTestPoints { get; set; } //punkty z druiego testu

        public decimal? FinalGrade { get; set; } //ostateczna ocena
    }
}