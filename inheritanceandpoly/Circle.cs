using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceandpoly
{
    public class Circle : Shape
    {
        public Point Center { get; protected set; }
        public double Radius { get; protected set;  }

        public override double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public Circle(Point p, double r)
        {
            Center = p;
            Radius = r;

            Name = "Circle";
        }

        public Circle(Point p, int r) : this(p, (double)r)
        {

        }

        public Circle(Point p, float r) : this(p, (double)r)
        {
            
        }

        public Circle(double r) : this(new Point(0,0), r)
        {
            
        }

     


        public override bool Equals(object obj)
        {
            var p = obj as Circle;
            if (p == null)
            {
                return false;
            }

            if (this.Center.Equals(p.Center) && this.Radius == p.Radius)
            {
                return true;
            }

            return false;
        }

    }
}
