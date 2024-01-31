using Complains_project.Models;
using Interns_Gate.Data;
using Interns_Gate.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Interns_Gate.Controllers
{
    public class StudentController : Controller
    {

        private readonly ILogger<StudentController> _logger;

 
        private readonly ApplicationDbContext _context;

   

        public StudentController(ILogger<StudentController> logger, ApplicationDbContext db)
        {
            _context = db;
            _logger = logger;
        }




        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HomePage_Stu()
        {

            return View();
        }
  


        // Get Rotation for DDL.
        private IEnumerable<SelectListItem> GetRotation()
        {

            List<SelectListItem> RotationList = _context.Rotation.Select(i =>
                       new SelectListItem
                       {
                           Text = i.Rot_name,
                           Value = i.Rot_id
                       }).ToList();

            return new SelectList(RotationList, "Value", "Text");

        }


        //Get Teeth for the DDL.
        private IEnumerable<SelectListItem> GetTeeth()
        {

            List<SelectListItem> TeethList = _context.Teeth.Select(i =>
                       new SelectListItem
                       {
                           Text = i.Tooth_no,
                           Value = i.Tooth_no
                       }).ToList();

            return new SelectList(TeethList, "Value", "Text");

        }
        public IActionResult NewCase()
        {
           
            var model = new DDLViewModel
            {
                RotationList = GetRotation(),
                TeethList = GetTeeth()
            };
            return View(model);

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
