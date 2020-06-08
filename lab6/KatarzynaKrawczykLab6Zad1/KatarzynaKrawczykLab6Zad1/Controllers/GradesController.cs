using KatarzynaKrawczykLab6Zad1.Models;
using KatarzynaKrawczykLab6Zad1.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KatarzynaKrawczykLab6Zad1.Controllers
{
    public class GradesController : ApiController
    {
        //zwraca wszystkie zaestawy ocen z bazy
        // GET: api/Grades
        public IHttpActionResult GetAllGrades(bool includeAddress = false)
        {
            IList<GradeModel> grades = null; //lista przechowująca wszystkie zestawy ocen w postaci modelu
            using (var context = new StudentsGradesDbEntities()) //połączenie z bazą danych
            {
                //wstawienie ocen z bazy do listy
                grades = context.Grades.Include("Grade").Select(g => new GradeModel()
                {
                    Id = g.Id,
                    Album = g.Album,
                    FirstTestPoints = g.FirstTestPoints,
                    SecondTestPoints = g.SecondTestPoints,
                    FinalGrade = g.FinalGrade
                }).ToList<GradeModel>(); 
            }
            //jeśli lista jest pusta zwraca "NotFound"
            if(grades.Count ==0)
            {
                return NotFound();
            }
            //przekazanie pozytywnego rezultatu z listą
            return Ok(grades);
        }
        //zwraca zestaw ocen zgodnych z podanym id 
        //GET: api/Grades?id=?
        public IHttpActionResult GetGradesByAlbum(int id)
        {
            GradeModel grade = null; //model oceny
            using (var context = new StudentsGradesDbEntities()) //połączenie z bazą danych
            {
                //pobranie zestawu ocen zgodych z danym id
                grade = context.Grades.Include("Grade").Where(g => g.Id == id).Select(g => new GradeModel()
                {
                    Id = g.Id,
                    Album = g.Album,
                    FirstTestPoints = g.FirstTestPoints,
                    SecondTestPoints = g.SecondTestPoints,
                    FinalGrade = g.FinalGrade
                }).FirstOrDefault<GradeModel>();
            }
            //jeśli nie znaleziono takiego zestawu zwraca "NotFound"
            if (grade == null)
            {
                return NotFound();
            }
            //zwrot pozytywnego rezultatu z zestawem
            return Ok(grade);
        }

        // zwraca zestawu ocen zgodnych z podanym nr albumu
        // GET: api/Grades?album=??????
        public IHttpActionResult GetGradesByAlbum(string album)
        {
            IList<GradeModel> grades = null; //lista zesatwów ocen
            using (var context = new StudentsGradesDbEntities()) //połączenie z bazą danych
            {
                //pobranie zestawów ocen zgodnych z podanym nr albumu
                grades = context.Grades.Include("Grade").Where(g => g.Album == album).Select(g => new GradeModel()
                {
                    Id = g.Id,
                    Album = g.Album,
                    FirstTestPoints = g.FirstTestPoints,
                    SecondTestPoints = g.SecondTestPoints,
                    FinalGrade = g.FinalGrade
                }).ToList<GradeModel>();
            }
            if (grades.Count == 0)
            {
                return NotFound();
            }
            return Ok(grades);
        }

        // utworzenie nowego zestawu ocen w bazie danych
        // POST: api/Grades
        public IHttpActionResult PostNewGrade(GradeModel grade)
        {
            //sprawdza czy przekazany obiekt grade posiada wszystkie potrzebne dane
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            using (var context = new StudentsGradesDbEntities()) //połączenie z bazą danych
            {
                //dodanie zestawu do bazy danych
                context.Grades.Add(new DbContext.Grade()
                {
                    Id = grade.Id,
                    Album = grade.Album,
                    FirstTestPoints = grade.FirstTestPoints,
                    SecondTestPoints = grade.SecondTestPoints,
                    FinalGrade = grade.FinalGrade
                });

                context.SaveChanges(); //zapisanie zmian
            }
            return Ok();
        }
         
        // Aktualizowanie podanego zestawu ocen
        // PUT: api/Grades/id
        public IHttpActionResult Put(GradeModel grade)
        {
            //sprawdza czy przeazany obiekt grade posiada wszystkie potrzebne dane
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            using (var context = new StudentsGradesDbEntities()) //połączenie z bazą danych
            {
                //pobiera zestaw z odpowiadającym id
                var existingGrade = context.Grades.Where(g => g.Id == grade.Id).FirstOrDefault<Grade>();
                // jeśli pobrany zestaw istnieje amienia jego dane na te z zestawu grade
                if(existingGrade != null)
                {
                    existingGrade.FirstTestPoints = grade.FirstTestPoints;
                    existingGrade.SecondTestPoints = grade.SecondTestPoints;
                    existingGrade.FinalGrade = grade.FinalGrade;
                    //zapisanie zmian
                    context.SaveChanges();
                }
                else
                {
                    //zwraca błąd jeśli wybrana ocena nie została znaleziona
                    return NotFound();
                }
            }

            return Ok();
        }

        // usuwamnie zesatwu ocen
        //DELETE: api/Grades/id
        public IHttpActionResult Delete (int id)
        {
            //sprawdzeie poprawności id 
            if (id <= 0)
                return BadRequest("Nieprawidłowe Id oceny");
            using (var context = new StudentsGradesDbEntities()) //połączneie z bazą danych
            {
                //usunięcie zestawu o podanym id z bazy danych
                var grade = context.Grades.Where(g => g.Id == id).FirstOrDefault();
                context.Entry(grade).State = System.Data.EntityState.Deleted;
                //zapisaie zmian w bazie danych
                context.SaveChanges();
            }
            return Ok();
        }

    }
}
