using KatarzynaKrawczykLab6Zad1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace KatarzynaKrawczykLab6Zad1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //Strona z wynikami studentów
        public ActionResult Results(string searchString)
        {
            //utworzenie zbioru modeli zestawu ocenu
            IEnumerable<GradeModel> grades = null;
            using (var client = new HttpClient())
            {  
                //połączenie z adresem api
                client.BaseAddress = new Uri("http://localhost:63957/api/");
                //HTTP GET 
                string path = null; 
                //jeśli wyszukanie jest puste zwraca wszystkie zestawy
                if (String.IsNullOrEmpty(searchString))
                    path = "grades";
                //jśli wyszukanie jest uzupełnione to zwraca zestawy z podanym nr albumu 
                else
                    path = "Grades?album=" + searchString;
                //użycie HTTP Get z wybraną ścieżką
                var responseTask = client.GetAsync(path);
                responseTask.Wait();

                var result = responseTask.Result;
                //w przypadku powodzenia przekazanie wyników do zbioru modeli
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<GradeModel>>();
                    readTask.Wait();

                    grades = readTask.Result;
                }
                //jeśli zajdzie niepowodzenie lub brak wyników wyświetli się komunikat
                else
                {
                    grades = Enumerable.Empty<GradeModel>();
                    ModelState.AddModelError(string.Empty, "Brak wyników");
                }
            }
            //przekazanie modeli do view
            return View(grades);
        }

        /// <summary>
        /// Widok utworzenia nowej oceny
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(GradeModel grade)
        {
            using (var client = new HttpClient())
            {
                //połączenie z adresem api
                client.BaseAddress = new Uri("http://localhost:63957/api/grades");

                //HTTP POST
                //dodanie zestawu ocen za pomocą POST
                var postTask = client.PostAsJsonAsync<GradeModel>("grades", grade);
                postTask.Wait();

                var result = postTask.Result;
                //jeśli powodzenie przekierouje do tabeli wyników
                if(result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Results");
                }
            }
            ModelState.AddModelError(string.Empty, "Wystapił problem");
            return View(grade);
        }

        /// <summary>
        /// Edycja utworzonego już zestawu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            GradeModel grade = null; //utworzenie nowego modelu zestawu ocen
            using (var client = new HttpClient())
            {
                //połączenie z api
                client.BaseAddress = new Uri("http://localhost:63957/api/");
                //HTTP GET
                //pobranie zestawu z odpowiadającym id
                var responseTask = client.GetAsync("Grades?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<GradeModel>();
                    readTask.Wait();

                    grade = readTask.Result;
                }
            }
            return View(grade);
        }

        [HttpPost]
        public ActionResult Edit(GradeModel grade)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:63957/api/grades");

                //HTTP POST
                var putTask = client.PutAsJsonAsync<GradeModel>("grades", grade);
                putTask.Wait();

                var result = putTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Results");
                }
            }
            return View(grade);
        }

        /// <summary>
        /// usuniecie zestawu ocen z bazy danych 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete (int id)
        {
            using (var client = new HttpClient())
            {
                //połączenie z api
                client.BaseAddress = new Uri("http://localhost:63957/api/");

                //HTTP DELETE
                //wywołanie DELET dla podane id
                var deleteTask = client.DeleteAsync("grades/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                //w przypadku powodzenia powrót do wyników
                if(result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Results");
                }
            }
            return RedirectToAction("Results");
        }
    }
}
