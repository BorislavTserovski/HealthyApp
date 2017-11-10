using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyApp.Models.Calculator
{
    public class CalculatorModel
    {
        public Gender Gender { get; set; }

        [Range(10, 500)]
        [Display(Name ="Weight in KGs")]
        public double Weight { get; set; }

        [Range(0.3,3.0)]
        [Display(Name = "Height in centimeters")]
        public double Height { get; set; }

        [Range(1,130)]
        public int Age { get; set; }
    }
}
