using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyApp.Models.Diets
{
    public class DietFormModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public byte[] Picture { get; set; }


    }
}
