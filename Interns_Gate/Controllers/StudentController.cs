
using Interns_Gate.Data;
using Interns_Gate.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Xml.Linq;

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
        private IEnumerable<SelectListItem> GetSupervisor()
        {

            List<SelectListItem> SupList = _context.supervisor_intern.Select(i =>
                       new SelectListItem
                       {
                           Text = i.Sup_fullname,
                           Value = i.Sup_id
                       }).ToList();

            return new SelectList(SupList, "Value", "Text");

        }

        public IActionResult NewCase(Clinical_case clinicalCaseModel)
        {

         

            var model = new DDLViewModel
            {
                Supervisor_internList = GetSupervisor(),
                RotationList = GetRotation(),
                TeethList = GetTeeth()
            };

            return View(model);

        } 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewCase(
        string Patient_file, string gender, string Citizenship, string Health_Category,
        string Rotation, string Age_group, string Department, string Case, string Tooth, string Supervisor, string DuplicateCase)
        {

           
    

            Clinical_case NewCaseRecord = new Clinical_case();


            NewCaseRecord.Stu_id = 00042235;
            NewCaseRecord.Patientcode = Patient_file;
            NewCaseRecord.Sup_Id = Supervisor;
            NewCaseRecord.Gender = gender;
            NewCaseRecord.Health_category = Health_Category;
            NewCaseRecord.Rot_id = Rotation;
            NewCaseRecord.Citizenship = Citizenship;
            NewCaseRecord.Score = 0;
            NewCaseRecord.Birth_date = DateTime.Now.ToString();
            NewCaseRecord.Age_group = Age_group;
            NewCaseRecord.Depratment_id = Department;
            NewCaseRecord.Case_id = Case;
            NewCaseRecord.Tooth_no = Tooth;
            NewCaseRecord.Create_date = DateTime.Now.ToString();
            NewCaseRecord.Accept_date = DateTime.Now.ToString();
            NewCaseRecord.End_date = DateTime.Now.ToString();
            NewCaseRecord.Evlaution_date = DateTime.Now.ToString();
            NewCaseRecord.Status_id = "1";
            NewCaseRecord.Measurement_type = "2";
            NewCaseRecord.Resubmission_reason = DuplicateCase;


            var isPatientCodeDuplicate = _context.Clinical_case.Where(x => x.Patientcode == Patient_file && x.Tooth_no == Tooth && x.Stu_id == 00042235).ToList();
            if (isPatientCodeDuplicate.Count == 0)
            {
        
              
              ModelState.AddModelError(string.Empty, "This Case is duplicate, you have the same patient and tooth in your records. To proceed please enter the duplication reason.");
                    _context.Clinical_case.Add(NewCaseRecord);
                    _context.SaveChanges();


                    return RedirectToAction("MyCases", "Student");
                

            }
            else // Duplicate case.
            {
                if(DuplicateCase == null)
                {

                    ModelState.AddModelError(string.Empty, "This Case is duplicate, you have the same patient and tooth in your records. To proceed please enter the duplication reason.");
                    return RedirectToAction("NewCase", "Student");

                }
                else
                {

                    // reason was entered for the duplicate case.
               
                        _context.Clinical_case.Add(NewCaseRecord);
                        _context.SaveChanges();
                        return RedirectToAction("MyCases", "Student");
                    

                }

           
            }


    

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
