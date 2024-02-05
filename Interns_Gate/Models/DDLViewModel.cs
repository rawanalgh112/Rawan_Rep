using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using Interns_Gate.Data;

namespace Interns_Gate.Models
{
    public class DDLViewModel
    {

    
        public int SelectedCaseRotation { get; set; }

        public IEnumerable<SelectListItem> RotationList { get; set; }

        public int SelectedTooth { get; set; }

        public IEnumerable<SelectListItem> TeethList { get; set; }

        public int SelectedSupervisor { get; set; }

        public IEnumerable<SelectListItem> Supervisor_internList { get; set; }

        public Clinical_case ClinicalCase_V_Model { get; set; }

    }
}