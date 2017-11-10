using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthyApp.Services.Diets;
using HealthyApp.Models.Diets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using HealthyApp.Models;

namespace HealthyApp.Controllers
{
    public class DietsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private IDietService diets;

        public DietsController(IDietService diets, UserManager<ApplicationUser> userManager)
        {
            this._userManager = userManager;
            this.diets = diets;
        }

        public IActionResult All()
        {
            return View(this.diets.All());
        }

        //GET
        public IActionResult Create()
        => View();

        //POST
        [HttpPost]
        public IActionResult Create(DietFormModel dietModel, IFormFile file)
        {
            string userId = _userManager.GetUserId(HttpContext.User);
            
            this.diets.Add(dietModel.Name, dietModel.Content, file, userId);

            return RedirectToAction(nameof(All));
        }
    }
}