using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceandpoly
{
    public class Point
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            var p = obj as Point;
            if(p == null)
            {
                return false;
            }

            if(this.X == p.X && this.Y == p.Y)
            {
                return true;
            }

            return false;
        }
    }

}
