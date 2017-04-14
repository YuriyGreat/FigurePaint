using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurePaint
{
    class Point
    {
        private double X, Y;
        public Point(double x, double y)
        {
            setX(x);
            setY(y);
        }

        public void setX(double x)
        {
            this.X = x;

        }

        public void setY(double y)
        {
            this.Y = y;
        }

        public double getX()
        {
            return X;
        }
        public double getY()
        {
            return Y;

        }
    }
}
