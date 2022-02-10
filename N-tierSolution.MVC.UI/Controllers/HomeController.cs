using Microsoft.AspNetCore.Mvc;
using N_tierSolution.MVC.UI.Models;
using System.Diagnostics;
using N_tierSolution.BLL;
using N_tierSolution.Entity;

namespace N_tierSolution.MVC.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BusinessLogic _businessLogic;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _businessLogic = new BusinessLogic();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public void AddStudent(int id)
        {
            var student = new Students()
            {
                Id = 1,
                Name = "John",
                Surname = "Doe"
            };

            _businessLogic.AddStudents(student);
        }

        public List<Students> GetListOfStudents()
        {
            return _businessLogic.GetStudentsList();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}