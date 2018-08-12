using NutritionWebAppCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NutritionWebAppCSharp.Controllers
{
    public class NutritionController : Controller
    {
        private const int fatCaloriesPerGram = 9;

        // GET: Nutrition
        public ActionResult Index()
        {
            ViewBag.Result = "Nutrition";
            return View();
        }

        //GET: Result
        public ActionResult Calculate(Calculation values)
        {
            if (!ModelState.IsValid)
            {
                return Json(values, JsonRequestBehavior.AllowGet);
            }

            double totalCaloriesFromFat = values.gramsOfFatPerServing * fatCaloriesPerGram;
            double percentCaloriesFromFat = totalCaloriesFromFat / values.caloriesPerServing;

            if (percentCaloriesFromFat < 0.3)
            {
                values.AHAapproved = "AHA approved";
            }
            else
            {
                values.AHAapproved = "NO AHA approved";
            }


            values.AHAapproved = String.Format("{0} contains {1:P2} calories from fat.\n It is {2} ", values.foodName, percentCaloriesFromFat, values.AHAapproved);

            return Json(values, JsonRequestBehavior.AllowGet); //View("Index", values);
        }

    }
}