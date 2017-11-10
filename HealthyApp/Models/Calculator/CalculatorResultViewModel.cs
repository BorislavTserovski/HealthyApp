using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyApp.Models.Calculator
{
    public class CalculatorResultViewModel
    {
        public double Result { get; set; }

        public string Message => $"Your Body Mass Index is {this.Result}";

        
    }
}
