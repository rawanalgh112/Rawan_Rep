using System.ComponentModel.DataAnnotations;
namespace Interns_Gate.Models
{
    public class Teeth
    {
         // 0 Pedo, 1 Adult, 2 Mix
         [Key]
        public string Tooth_no { get; set; }
        public string Type { get; set; }
    }
}
