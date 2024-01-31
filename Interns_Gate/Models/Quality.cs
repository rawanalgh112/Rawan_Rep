using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Interns_Gate.Models
{
    [PrimaryKey(nameof(Case_id))]
    public class Quality
    {

        
        public int Case_id { get; set; }
    
        public required string M_ID { get; set;}
    }
}
