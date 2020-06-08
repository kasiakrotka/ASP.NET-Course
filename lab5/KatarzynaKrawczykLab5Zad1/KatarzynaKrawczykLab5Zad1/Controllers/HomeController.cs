using KatarzynaKrawczykLab5Zad1.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatarzynaKrawczykLab5Zad1.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// strona główna
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// zakłada o mnie + kontakt
        /// </summary>
        /// <returns></returns>
        public ActionResult AboutMe()
        {
            return View();
        }
        /// <summary>
        /// zakłądka ze sklepem 
        /// </summary>
        /// <returns></returns>
        public ActionResult Shop()
        {
            using (var context = new DatabaseContext())
            {
                var products = context.Product.ToList();
                return View("Shop", products);
            }
        }
        /// <summary>
        /// zakładka z galerią obrazów
        /// </summary>
        /// <returns></returns>
        public ActionResult ArtGallery()
        {
            using (var context = new DatabaseContext())
            {
                var arts = context.Art.ToList();
                return View(arts);
            }
        }
        /// <summary>
        /// zakłądka z prezentacją wybranego obrazu 
        /// </summary>
        /// <param name="art"></param>
        /// <returns></returns>
        public ActionResult ArtPresentation(Art art)
        {
            return View("ArtPresentation", art);
        }
        /// <summary>
        /// zakłada tworząca adres kupującego 
        /// </summary>
        /// <returns></returns>
        public ActionResult PaymentForm()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult PaymentForm(Client client)
        {
            using (var context = new DatabaseContext())
            {
                context.Client.Add(client);
                context.SaveChanges();
            }
            return Redirect("https://www.paypal.com");
        }

    }
}
