using System.ComponentModel.DataAnnotations;
namespace Interns_Gate.Models
{
    public class Rotation
    {
         
         [Key]
        public string rot_id { get; set; }
        public string rot_name { get; set; }
    }
}
