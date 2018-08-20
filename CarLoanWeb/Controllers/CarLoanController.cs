using CarLoanWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarLoanWeb.Controllers
{
    public class CarLoanController : Controller
    {
        // GET: CarLoan
        public ActionResult Index()
        {
            var test = new CarLoanModel();
            test.interestRate = 100;
            return View(test);
        }
        [HttpPost]
        public ActionResult Calculate(CarLoanModel carLoanModel)
        {
            ModelState.Clear();
            carLoanModel.totalInterestPaid = 200;
            carLoanModel.monthlyPayment = 20;
            carLoanModel.interestRate = 0;
            //Response.OutputStream.Write(writeBuffer, 0, count);
            return View("Index", carLoanModel);
        }

    }
}