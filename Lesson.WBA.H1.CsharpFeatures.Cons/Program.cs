using Lesson.WBA.H1.CsharpFeatures.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Lesson.WBA.H1.CsharpFeatures.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> household = Furniture.GetAll();
            foreach (Furniture furniture in household)
            {
                int? id = furniture?.Id;
                KnownColor? color = furniture?.Color;
                FurnitureType? type = furniture?.Type;
                string description = furniture?.Description ?? "Furniture with no description";

                string message = $"Furniture {id}\n\tType: {type}\n\tColor: {color}\n\tDescription: {description}\n\n";
                Console.WriteLine(message);
            }
        }
    }
}
