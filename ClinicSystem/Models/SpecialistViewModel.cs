using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace ClinicSystem.Models
{
    public class SpecialistViewModel
    {
        public List<Visit> Visits;
        public SelectList Specialists;
        public string PatientSpecialist { get; set; }
        public string SearchString { get; set; }
    }
}
