using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCbasicsAssignment01.Models
{
    public class Doctor
    {
        [Display(Name="temperature")]
        [Range(0, double.PositiveInfinity)]
        [Required]
        public float PatientTemp { get; set; }
        [Required]
        public bool IsFahrenheit { get; set; }

    }
}