using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ClinicSystem.Models
{
    public class DistrictViewModel
    {
        public List<Patient> Patients;
        public SelectList Districts;
        public string PatientDistrict { get; set; }
        public string SearchString { get; set; }
    }
}
