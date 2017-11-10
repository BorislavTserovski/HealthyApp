using HealthyApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using HealthyApp.Data.Models;

using System.Security.Claims;
using HealthyApp.Models;
using Microsoft.AspNetCore.Identity;
using HealthyApp.Models.Diets;

namespace HealthyApp.Services.Diets
{
    

    public class DietService:IDietService
    {
       

        private HealthyAppDbContext db;

        public DietService(HealthyAppDbContext db)
        {
          
            this.db = db;
        }


        public void Add(string name, string content, IFormFile file, string userId)
        {
            Diet diet = new Diet();
            using (MemoryStream ms = new MemoryStream())
            {
                if (file != null)
                {
                    file.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                    diet.Picture = array;
                }
            }
            
            diet.Name = name;
            diet.Content = content;
            diet.AuthorId = userId;
            

            

            this.db.Diets.Add(diet);
            this.db.SaveChanges();
          
        }

        public IEnumerable<DietFormModel> All()
        {
            return this.db.Diets.Select(d => new DietFormModel
            {
                Name = d.Name,
                Content = d.Content,
                Picture = d.Picture
            }).ToList();
        }
    }
}
