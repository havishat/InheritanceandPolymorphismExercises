using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceandpoly
{
    public class Rectangle : Shape
    {
        

        public Point TopLeft { get; protected set; }
        public double Width { get; protected set; }
        public double Height { get; protected set; }

        public override double Area
        {
            get
            {
                return Width * Height;
             }

        }

        public Rectangle(Point p, double w, double h)
        {
            TopLeft = p;
            Width = w;
            Height = h;

            Name = "Rectangle";

        }


        public Rectangle()
        {
        }

        public override bool Equals(object obj)
        {
            var p = obj as Rectangle;
            if (p == null)
            {
                return false;
            }

            if (this.TopLeft.Equals(p.TopLeft) && this.Width == p.Width && this.Height == p.Height)
            {
                return true;
            }

            return false;
        }
    }
}
