
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
     
        public IActionResult NewCase(DDLViewModel m)

        {

            Clinical_case NewCaseRecord = new Clinical_case();


            NewCaseRecord.Stu_id = 00042235;
            NewCaseRecord.Patientcode = m.ClinicalCase_V_Model.Patientcode;
            NewCaseRecord.Sup_Id = m.SelectedSupervisor;
            NewCaseRecord.Gender = m.ClinicalCase_V_Model.Gender;
            NewCaseRecord.Health_category = m.ClinicalCase_V_Model.Health_category;
            NewCaseRecord.Rot_id = m.SelectedCaseRotation;
            NewCaseRecord.Citizenship = m.ClinicalCase_V_Model.Citizenship;
            NewCaseRecord.Score = 0;
            NewCaseRecord.Birth_date = DateTime.Now.ToString();
            NewCaseRecord.Age_group = m.ClinicalCase_V_Model.Age_group;
            NewCaseRecord.Depratment_id = m.ClinicalCase_V_Model.Depratment_id;
            NewCaseRecord.Case_id = m.ClinicalCase_V_Model.Case_id;
            NewCaseRecord.Tooth_no = m.SelectedTooth;
            NewCaseRecord.Create_date = DateTime.Now.ToString();
            NewCaseRecord.Accept_date = DateTime.Now.ToString();
            NewCaseRecord.End_date = DateTime.Now.ToString();
            NewCaseRecord.Evlaution_date = DateTime.Now.ToString();
            NewCaseRecord.Status_id = "1";
            NewCaseRecord.Measurement_type = "2";
            NewCaseRecord.Resubmission_reason = m.ClinicalCase_V_Model.Resubmission_reason;



            var isPatientCodeDuplicate = _context.Clinical_case.Where(x => x.Patientcode == NewCaseRecord.Patientcode && x.Tooth_no == NewCaseRecord.Tooth_no && x.Stu_id == 00042235).ToList();

            if (isPatientCodeDuplicate.Count == 0)
            {
        
              
              ModelState.AddModelError(string.Empty, "This Case is duplicate, you have the same patient and tooth in your records. To proceed please enter the duplication reason.");
                    _context.Clinical_case.Add(NewCaseRecord);
                    _context.SaveChanges();


                    return RedirectToAction("MyCases", "Student");
                

            }
            else // Duplicate case.
            {
                if(m.ClinicalCase_V_Model.Resubmission_reason.ToString() == null)
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
