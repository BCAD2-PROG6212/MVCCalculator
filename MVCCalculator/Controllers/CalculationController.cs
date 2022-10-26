using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCalculator.Controllers
{
    public class CalculationController : Controller
    {
        // GET: CalculationController
        public ActionResult Index()
        {
            return View();
        }

        // POST: CalculationController/
        [HttpPost]
        public ActionResult Index(int firstValue, int secondValue, int mathOp)
        {
            Calculation calc = new Calculation(firstValue, secondValue, mathOp);
            double result = calc.performCalculation();
            ViewBag.Result = result;
            return View();
        }
    }
}
