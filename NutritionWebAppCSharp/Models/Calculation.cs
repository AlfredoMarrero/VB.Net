using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NutritionWebAppCSharp.Models
{
    public class Calculation
    {
        [Display(Name = "Name Of Food")]
        public string foodName { get; set; }
        public string AHAapproved { get; set; }

        [Display(Name = "Calories Per Serving")]
        [Required]
        public double caloriesPerServing { get; set; }
        [Display(Name = "Grams Of Fat Per Serving")]
        [Required]
        public double gramsOfFatPerServing { get; set; }
        
        public double percentCaloriesFromFat { get; set; }
    }
}