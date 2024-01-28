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

        public int stuCase_id { get; set; }       
        public int stu_id { get; set; }
        public string patientcode { get; set; }
  
        public string sup_id { get; set; }
        public string Gender { get; set; }

        public string health_category { get; set; }

        public string rot_id { get; set; }
        public string tooth_num { get; set; }

        public string citizenship { get; set; }

        public int score { get; set; }
        public string birth_date { get; set; }
        public string age_group{ get; set; }
        public string depratment_id { get; set; }
        public string case_id { get; set; }

        public string Tooth_no { get; set; }
        public string create_date { get; set; }
        public string accept_date { get; set; }
        public string end_date { get; set; }
        public string evlaution_date { get; set; }
        public string status_id { get; set; }
        public string measurement_type { get; set; }







    }
}
