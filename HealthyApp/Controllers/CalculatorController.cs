using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthyApp.Models.Calculator;
using HealthyApp.Services.Calculator;

namespace HealthyApp.Controllers
{
    public class CalculatorController : Controller
    {
        private ICalculatorService calculators;

        public CalculatorController(ICalculatorService calculators)
        {
            this.calculators = calculators;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult Calculate()
        {
            return View();
        }

        //POST
        [HttpPost]
        public IActionResult Calculate(CalculatorModel calculatorModel )
        {
            double result = this.calculators.Calculate
                (calculatorModel.Gender, calculatorModel.Weight, calculatorModel.Height, calculatorModel.Age);
            CalculatorResultViewModel viewModel = new CalculatorResultViewModel
            {
                Result = result
            };
            return View(nameof(Result), viewModel);
        }

        public IActionResult Result(CalculatorModel calculatorModel)
        {
            double result = this.calculators.Calculate
                (calculatorModel.Gender, calculatorModel.Weight, calculatorModel.Height, calculatorModel.Age);
            CalculatorResultViewModel viewModel = new CalculatorResultViewModel
            {
                Result = result
            };
            return View(viewModel);
        }

       
    }
}