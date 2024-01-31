using System.ComponentModel.DataAnnotations;
namespace Interns_Gate.Models
{
    public class Rotation
    {
         
         [Key]
        public required string Rot_id { get; set; }
        public required string Rot_name { get; set; }
    }
}
