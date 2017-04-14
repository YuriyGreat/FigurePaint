﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurePaint
{
    class Line : Shape
    {
        Point secondPoint;

        public Line(Point firstPoint, Point secondPoint) : base(firstPoint)
        {
            this.secondPoint = secondPoint;
        }
        public void setSecondPoint(Point secondPoint)
        {
            this.secondPoint = secondPoint;
        }
        public Point GetSecondPoint()
        {
            return secondPoint;
        }
    }
}
