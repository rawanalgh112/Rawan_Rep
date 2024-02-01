using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using Interns_Gate.Data;

namespace Interns_Gate.Models
{
    public class DDLViewModel
    {

        [Display(Name = "Rotation")]
        public int SelectedCaseRotation { get; set; }
        public required IEnumerable<SelectListItem> RotationList { get; set; }

        public int SelectedTooth { get; set; }
        public required IEnumerable<SelectListItem> TeethList { get; set; }


        public Clinical_case ClinicalCase_V_Model { get; set; }
    }
}