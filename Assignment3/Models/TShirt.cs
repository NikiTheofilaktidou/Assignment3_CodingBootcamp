using Assignment3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class TShirt
    {
        public TShirt(Color color, Fabric fabric, Size size)
        {
            Color = color;
            Fabric = fabric;
            Size = size;
        }

        public Color Color { get; set; }
        public Fabric Fabric { get; set; }
        public Size Size { get; set; }
        public decimal Price { get; set; }
    }
}
