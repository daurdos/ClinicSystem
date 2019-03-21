using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicSystem.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [MaxLength(12)]
        [MinLength(12)]
        [Required]
        [Display(Name = "IIN")]
        public string Iin { get; set; }


        [StringLength(30, MinimumLength = 1)]
        [Required]
        [Display(Name = "Name")]
        public string FName { get; set; }
        

        [StringLength(30, MinimumLength = 1)]
        [Required]
        [Display(Name = "Surname")]
        public string LName { get; set; }


        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string Address { get; set; }


        [StringLength(10, MinimumLength = 10)]
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Phone { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(20, MinimumLength = 4)]
        [Required]
        public string District { get; set; }
    }
}


