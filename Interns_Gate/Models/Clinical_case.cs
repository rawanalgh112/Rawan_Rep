using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.Operations;
using System.ComponentModel.DataAnnotations;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
 
namespace Interns_Gate.Models
{
    public class Clinical_case
    {
        [Key]

        public int StuCase_id { get; set; }       
        public int Stu_id { get; set; }
        public string? Patientcode { get; set; }
  
        public string Sup_Id { get; set; }
        public string Gender { get; set; }

        public string Health_category { get; set; }

        public string Rot_id { get; set; }


        public string Citizenship { get; set; }

        public int Score { get; set; }
        public string Birth_date { get; set; }
        public string Age_group{ get; set; }
        public string Depratment_id { get; set; }
        public string Case_id { get; set; }

        public string Tooth_no { get; set; }
        public string Create_date { get; set; }
        public string Accept_date { get; set; }
        public string End_date { get; set; }
        public string Evlaution_date { get; set; }
        public string Status_id { get; set; }
        public string Measurement_type { get; set; }


        public string Resubmission_reason { get; set; }





    }
}
