using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Adam", LastName = "Smith", Age = 27 });
            people.Add(new PersonModel { FirstName = "Eve", LastName = "Wayne", Age = 25 });
            people.Add(new PersonModel { FirstName = "Cloud", LastName = "Bourne", Age = 26 });
            return View(people);
        }
    }
}