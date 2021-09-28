using Lesson.WBA.H1.CsharpFeatures.Domain;
using Lesson.WBA.H1.CsharpFeatures.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson.WBA.H1.CsharpFeatures.Web.Controllers
{
    public class FurnitureController : Controller
    {
        public IActionResult Index()
        {
            // niet volgens conventie:
            // - we geven een List mee
            // - we gebruiken een domain klasse en geen ViewModel
            List<Furniture> furniture = Furniture.GetAll();
            return View(furniture);
        }

        public IActionResult Details()
        {
            ViewData["Title"] = "Furniture details";

            List<Furniture> allFurniture = Furniture.GetAll();
            FurnitureListViewModel furnitureListViewModel = new FurnitureListViewModel
            {
                Furniture = allFurniture,
                Count = allFurniture.Count,
                QuoteOfTheDay = "The best furniture in town"
            };
            return View(furnitureListViewModel);
        }


    }
}
