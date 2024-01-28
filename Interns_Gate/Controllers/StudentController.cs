using Microsoft.AspNetCore.Mvc;

namespace Interns_Gate.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HomePage_Stu()
        {

            return View();
        }

        public IActionResult NewCase()
        {
            return View();
        }

        public IActionResult MyCases()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
   
        public IActionResult Clinical_Evaluation()
        {
            return View();
        }


    }
}
