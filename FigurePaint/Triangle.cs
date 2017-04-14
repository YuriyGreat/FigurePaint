using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurePaint
{
    class Triangle : Shape
    {
        Point secondPoint;
        Point thirdPoint;
        public Triangle(Point firstPoint, Point secondPoint, Point thirdPoint) : base(firstPoint)
        {
            this.secondPoint = secondPoint;
            this.thirdPoint = thirdPoint;
        }
        public void setSecondPoint(Point secondPoint)
        {
            this.secondPoint = secondPoint;
        }
        public Point GetSecondPoint()
        {
            return secondPoint;
        }
        public void setThirdPoint(Point thirdPoint)
        {
            this.thirdPoint = thirdPoint;
        }
        public Point GetThirdPoint()
        {
            return thirdPoint;
        }
    }
}
