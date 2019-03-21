using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicSystem.Models
{
    public class Visit
    {
        public int VisitId { get; set; }

        public string SFName { get; set; }
        public string SLName { get; set; }
        public string Specialist { get; set; }
        public string Complaint { get; set; }
        public string Diagnosis { get; set; }
        public DateTime VisitDate { get; set; }

        public int PatientId { get; set; }

        public string PatientIin { get; set; }
    }
}
