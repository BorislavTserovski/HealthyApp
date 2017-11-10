using HealthyApp.Models.Diets;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyApp.Services.Diets
{
   public interface IDietService
    {
        void Add(string name, string content, IFormFile file, string userId);

        IEnumerable<DietFormModel> All();
    }
}
