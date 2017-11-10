using HealthyApp.Models.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyApp.Services.Calculator
{
    public interface ICalculatorService
    {
        double Calculate(Gender gender, double weight, double height, int age);
    }
}
