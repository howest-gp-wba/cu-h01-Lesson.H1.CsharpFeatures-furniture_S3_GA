using Lesson.WBA.H1.CsharpFeatures.Domain;
using System.Collections.Generic;

namespace Lesson.WBA.H1.CsharpFeatures.Web.ViewModels
{
    public class FurnitureListViewModel
    {
        public List<Furniture> Furniture { get; set; }
        public int Count { get; set; }
        public string QuoteOfTheDay { get; set; }
    }
}
