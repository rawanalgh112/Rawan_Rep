using System.ComponentModel.DataAnnotations;

namespace Interns_Gate.Models
{
    public class Clinical_status
    {
        [Key]
        public string status_id { get; set; }
        public string name { get; set; }
    }
}
