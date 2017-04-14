using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FigurePaint
{
    class TriangleDrawer : FigureDrawer
    {
        private bool isDrawig = false;
        private Triangle triangle;

        private System.Windows.Shapes.Line triangleSide1;
        private System.Windows.Shapes.Line triangleSide2;
        private System.Windows.Shapes.Line triangleSide3;
        private Point point;

        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (isDrawig)
            {
                point = new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y);
                triangle.setSecondPoint(point);
                triangle.setThirdPoint(new Point(triangle.GetFirstPoint().getX(), triangle.GetSecondPoint().getY()));

                triangleSide1.X1 = triangle.GetFirstPoint().getX();
                triangleSide1.Y1 = triangle.GetFirstPoint().getY();
                triangleSide1.X2 = triangle.GetSecondPoint().getX();
                triangleSide1.Y2 = triangle.GetSecondPoint().getY();
                triangleSide2.X1 = triangle.GetSecondPoint().getX();
                triangleSide2.Y1 = triangle.GetSecondPoint().getY();
                triangleSide2.X2 = triangle.GetThirdPoint().getX();
                triangleSide2.Y2 = triangle.GetThirdPoint().getY();
                triangleSide3.X1 = triangle.GetThirdPoint().getX();
                triangleSide3.Y1 = triangle.GetThirdPoint().getY();
                triangleSide3.X2 = triangle.GetFirstPoint().getX();
                triangleSide3.Y2 = triangle.GetFirstPoint().getY();
            }
        }
        public override void OnMouseUp(Object sender, MouseEventArgs e)
        {
            isDrawig = false;
        }
        public override void OnMouseDown(Object sender, MouseEventArgs e)
        {
            isDrawig = true;
            point = new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y);
            triangle = new Triangle(point, point, point);

            triangleSide1 = new System.Windows.Shapes.Line();
            triangleSide2 = new System.Windows.Shapes.Line();
            triangleSide3 = new System.Windows.Shapes.Line();

            triangleSide1.X1 = triangleSide2.X1 = triangleSide3.X1 = triangleSide1.X2 = triangleSide2.X2 = triangleSide3.X2 = point.getX();
            triangleSide1.Y1 = triangleSide2.Y1 = triangleSide3.Y1 = triangleSide1.Y2 = triangleSide2.Y2 = triangleSide3.Y2 = point.getY();

            triangleSide1.Stroke = triangleSide2.Stroke = triangleSide3.Stroke = Brushes.Red;
            canvas.Children.Add(triangleSide1);
            canvas.Children.Add(triangleSide2);
            canvas.Children.Add(triangleSide3);
        }
    }
}
