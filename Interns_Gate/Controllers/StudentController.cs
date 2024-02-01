
using Interns_Gate.Data;
using Interns_Gate.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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

       
        public IActionResult NewCase(Clinical_case clinicalCaseModel)
        {
            int stuCase_idVar = clinicalCaseModel.StuCase_id;
            int Stu_idVar = clinicalCaseModel.Stu_id;
            string PatientcodeVar = clinicalCaseModel.Patientcode;
            string Sup_IdVar = clinicalCaseModel.Sup_Id;
            string GenderVar = clinicalCaseModel.Gender;
            string Health_categoryVar = clinicalCaseModel.Health_category;
            string Rot_idVar = clinicalCaseModel.Rot_id;
            string CitizenshipVar = clinicalCaseModel.Citizenship;
            int ScoreVar = clinicalCaseModel.Score;
            string BirthdateVar = clinicalCaseModel.Birth_date;
            string AgegroupVar = clinicalCaseModel.Age_group;
            string DepratmentidVar = clinicalCaseModel.Depratment_id;
            string Case_idVar = clinicalCaseModel.Case_id;
            string Tooth_noVar = clinicalCaseModel.Tooth_no;
            string Create_dateVar = clinicalCaseModel.Create_date;
            string Accept_dateVar = clinicalCaseModel.Accept_date;
            string End_dateVar = clinicalCaseModel.End_date;
            string Evlaution_dateVar = clinicalCaseModel.Evlaution_date;
            string Status_idVar = clinicalCaseModel.Status_id;
            string Measurement_typeVar = clinicalCaseModel.Measurement_type;







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


        public ActionResult SubmitCaseButton(Clinical_case clinicalCaseModel)
        {

            int stuCase_idVar = clinicalCaseModel.StuCase_id;
            int Stu_idVar = clinicalCaseModel.Stu_id;
            string PatientcodeVar = clinicalCaseModel.Patientcode;
            string Sup_IdVar = clinicalCaseModel.Sup_Id;
            string GenderVar = clinicalCaseModel.Gender;
            string Health_categoryVar = clinicalCaseModel.Health_category;
            string Rot_idVar = clinicalCaseModel.Rot_id;

            string CitizenshipVar = clinicalCaseModel.Citizenship;
            int ScoreVar = clinicalCaseModel.Score;
            string BirthdateVar = clinicalCaseModel.Birth_date;
            string AgegroupVar = clinicalCaseModel.Age_group;
            string DepratmentidVar = clinicalCaseModel.Depratment_id;
            string Case_idVar = clinicalCaseModel.Case_id;
            string Tooth_noVar = clinicalCaseModel.Tooth_no;
            string Create_dateVar = clinicalCaseModel.Create_date;
            string Accept_dateVar = clinicalCaseModel.Accept_date;
            string End_dateVar = clinicalCaseModel.End_date;
            string Evlaution_dateVar = clinicalCaseModel.Evlaution_date;
            string Status_idVar = clinicalCaseModel.Status_id;
            string Measurement_typeVar = clinicalCaseModel.Measurement_type;





            return LocalRedirect("~/Student/NewCase");

        }


    }
}
