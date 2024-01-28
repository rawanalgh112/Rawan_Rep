using Microsoft.AspNetCore.Mvc;

namespace Interns_Gate.Controllers
{
    public class SupervisorController : Controller
    {

        private readonly ILogger<SupervisorController> _logger;

        public SupervisorController(ILogger<SupervisorController> logger)
        {
            _logger = logger;
        }


        public IActionResult HomePage_Supervisor()
        {
            return View();
        }

              public IActionResult Pretreatment_Requests_Sup()
        {
            return View();
        }     
        
        public IActionResult Clinical_Evaluations_Sup()
        {
            return View();
        }
        public IActionResult Case_details()
        {
            return View();
        }
                public IActionResult Case_Evaluate()
        {
            return View();
        }





    }
}
