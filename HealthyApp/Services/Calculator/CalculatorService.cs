using HealthyApp.Models.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyApp.Services.Calculator
{
    public class CalculatorService : ICalculatorService
    {
        public double Calculate(Gender gender, double weight, double height, int age)
        {
            return Math.Round(weight / ((height / 100) * (height / 100)),2);
        }
    }
}
