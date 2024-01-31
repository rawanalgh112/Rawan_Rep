using System.ComponentModel.DataAnnotations;


namespace Interns_Gate.Models
{
    public class Supervisor_intern
    {
        [Key]
        public string Sup_id { get; set; }
        public string Sup_fullname { get; set; }
    }
}