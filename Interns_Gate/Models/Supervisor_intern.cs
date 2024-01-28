using System.ComponentModel.DataAnnotations;


namespace Interns_Gate.Models
{
    public class Supervisor_intern
    {
        [Key]
        public string sup_id { get; set; }
        public string sup_fullname { get; set; }
    }
}