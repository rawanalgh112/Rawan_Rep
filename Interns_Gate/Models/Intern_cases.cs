using System.ComponentModel.DataAnnotations;


namespace Interns_Gate.Models
{
    public class Intern_cases
    {
      

       [Key]
        public int Case_id { get; set; }
        public string Case_name { get; set; }
        public string Category { get; set; }
        public string AgeGroup { get; set; }
        public string Active { get; set; }


    }
}
