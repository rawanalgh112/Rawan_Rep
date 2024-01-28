using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Interns_Gate.Models
{
    [PrimaryKey(nameof(Case_id), nameof(score))]
    public class Quantity
    {
      
        public int Case_id { get; set; }
        public string score { get; set; }
    }
}
