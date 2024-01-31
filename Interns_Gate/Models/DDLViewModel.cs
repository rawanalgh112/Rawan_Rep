using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace Complains_project.Models
{
    public class DDLViewModel
    {

        [Display(Name = "Rotation")]
        public int SelectedCaseRotation { get; set; }
        public required IEnumerable<SelectListItem> RotationList { get; set; }

        public int SelectedTooth { get; set; }
        public required IEnumerable<SelectListItem> TeethList { get; set; }
    }
}