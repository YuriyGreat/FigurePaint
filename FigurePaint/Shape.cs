namespace FigurePaint
{
    abstract class Shape
    {
        private Point FirstPoint;

        public Shape(Point firstPoint)
        {
            SetFirstPoint(firstPoint);
        }


        public void SetFirstPoint(Point firstPoint)
        {
            this.FirstPoint = firstPoint;
        }

        public Point GetFirstPoint()
        {
            return FirstPoint;
        }

    }


}
