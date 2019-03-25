using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicSystem.Models
{
    public class Visit
    {
        public int VisitId { get; set; }

        [StringLength(30, MinimumLength = 1)]
        [Required]
        [Display(Name = "Specialist Name")]
        public string SFName { get; set; }

        [StringLength(30, MinimumLength = 1)]
        [Required]
        [Display(Name = "Specialist Surname")]
        public string SLName { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        [Display(Name = "Specialist")]
        public string Specialist { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Complaint { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Diagnosis { get; set; }

        [Required]
        [Display(Name = "Date of Visit")]
        public DateTime VisitDate { get; set; }


        [Display(Name = "Patient ID")]
        public int PatientId { get; set; }

        public Patient Patient { get; set; }

    }
}
