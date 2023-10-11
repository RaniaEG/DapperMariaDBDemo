using Microsoft.AspNetCore.Mvc;
using DapperMariaDBDemo.Models;

namespace DapperMariaDBDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly PersonRepository _repository;

        public HomeController(PersonRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var people = _repository.GetAll();
            return View(people);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(person);
                return RedirectToAction("Index");
            }
            return View(person);
        }
    }
}
