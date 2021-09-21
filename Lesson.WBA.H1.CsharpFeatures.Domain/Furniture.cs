using System;
using System.Collections.Generic;
using System.Drawing;

namespace Lesson.WBA.H1.CsharpFeatures.Domain
{
    public class Furniture
    {
        public int? Id { get; set; }
        public FurnitureType? Type { get; set; }
        public KnownColor? Color { get; set; }
        public string Description { get; set; }

        public static List<Furniture> GetAll()
        {
            return new List<Furniture> {
                new Furniture { 
                    Id = 1, 
                    Type = FurnitureType.Chair, 
                    Color = KnownColor.Orange, 
                    Description = "Nice orange chair"
                },
                new Furniture {
                    Id = 2,
                    Type = FurnitureType.Table,
                    Color = KnownColor.Gray,
                    Description = "Gray table"
                },
                new Furniture {
                    Id = 3,
                    Type = FurnitureType.Seat,
                    Color = KnownColor.Green,
                    Description = "Green seat"
                },
                null,
                new Furniture {
                    Id = 4,
                    Type = FurnitureType.Seat,
                    Color = KnownColor.Green,
                    Description = null
                },

            };
        }

    }

    public enum FurnitureType { Chair, Table, Closet, Seat }
}
