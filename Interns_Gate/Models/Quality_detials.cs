using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Interns_Gate.Models
{

    [PrimaryKey(nameof(M_type), nameof(M_ID))]
    public class Quality_detials
    {
       
        public int M_type { get; set; }
  
        public string M_ID { get; set; }
        public string Score { get; set; }


     
    }
}
