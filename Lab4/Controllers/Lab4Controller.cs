using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            var CurrentDateTime = DateTime.Now;
            var CurrentYear = CurrentDateTime.Year;
            var DeclareNextYear = CurrentDateTime.AddYears(1);
            var NextYear = DeclareNextYear.Year;
            var NewYears = new DateTime(NextYear, 1, 1);
            var DaysRemaining = NewYears.Subtract(CurrentDateTime).Days;
            var TimeHour = CurrentDateTime.Hour;
            var DateString = CurrentDateTime.ToString("D");
            var TimeString = CurrentDateTime.ToString("t");
            if (TimeHour < 12)
            {
                ViewData["Greeting"] = "Good Morning!";
            }
            else if (TimeHour >= 12 && TimeHour < 18)
            {
                ViewData["Greeting"] = "Good Afternoon!";
            }
            else 
            { 
                ViewData["Greeting"] = "Good Evening!";
            }

            ViewData["CurrentDateTime"] = "The time is" + " " + TimeString + " " + "on" + " " + DateString;
            ViewData["DaysTillNext"] = "There are" + " " + DaysRemaining  + " " + "days" + " " + "remaining until" + " " + NextYear;
            return View();
        }
            public IActionResult Page2(int id)
        {
            ViewData["Num"] = id;
            return View(id);
        }
       public IActionResult Page3()
        {
            
            //ViewBag.Beverages = Beverages;
            ViewData["Pg3Title"] = "Beverages";
            return View(new string[5] { "Coffee", "Tea", "Beer", "Coke", "Wine" });
        }
    }
}