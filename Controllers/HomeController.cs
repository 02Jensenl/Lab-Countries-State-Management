using Lab_Countries_State_Management.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_Countries_State_Management.Controllers
{
    public class HomeController : Controller
    {
         public List<Country> Countries = new List<Country> {
            new Country("Germany", "German", "Hallo Welt!", "Germany is the seventh-largest country in Europe", "Black, Red, Yellow"),
            new Country("Iceland", "Icelandic", "Hallo heimur!","About 11% of Iceland is covered by glaciers", "Blue, White, Red"),
            new Country("Greece", "Greek", "Geia sou Kosme!", " Voting is required by law for every citizen who is 18 or older", "White, Blue"),
            new Country("Poland", "Polish", "Witaj swiecie!","Poland was the 2nd country in the world to have a legal constitution" ,"White, Red"),
            new Country("Madagascar", "Malagasy and French", "Hello World!, Bonjour le monde! ","Madagasgar is the the world’s fourth largest island" ,"White, Red, Green")
        };

       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CountryDetails(int country)
        {
            Country c = Countries[country];

            TempData["Name"] = c.Name;
            TempData["Lang"] = c.Languages;
            TempData["Hello"] = c.Hello;
            TempData["Colors"] = c.Colors;
            TempData["Description"] = c.Description;
            //TempData["Flag"] = c.Flag;

            //TempData.Keep("Description");

            return View();
        }

        public IActionResult CountryDescription()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
