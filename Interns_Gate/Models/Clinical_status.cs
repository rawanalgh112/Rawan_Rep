using System.ComponentModel.DataAnnotations;

namespace Interns_Gate.Models
{
    public class Clinical_status
    {
        [Key]
        public string Status_id { get; set; }
        public string Name { get; set; }


     

    }
}
