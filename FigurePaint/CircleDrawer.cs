using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FigurePaint
{
    class CircleDrawer:FigureDrawer
    {
        private bool isDrawig = false;
        private Circle circle;
        private System.Windows.Shapes.Ellipse circleForDraw;

        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (isDrawig)
            {
                circle.setSecondPoint(new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y));
                if (circle.GetSecondPoint().getX() < circle.GetFirstPoint().getX())
                {
                    circleForDraw.SetValue(Canvas.LeftProperty, circle.GetSecondPoint().getX());
                }
                if (circle.GetSecondPoint().getY() < circle.GetFirstPoint().getY())
                    circleForDraw.SetValue(Canvas.TopProperty, circle.GetSecondPoint().getY());

                circleForDraw.Width = Math.Abs(circle.GetFirstPoint().getX() - circle.GetSecondPoint().getX());
                circleForDraw.Height = circleForDraw.Width;
            }
        }
        public override void OnMouseUp(Object sender, MouseEventArgs e)
        {
            isDrawig = false;
        }
        public override void OnMouseDown(Object sender, MouseEventArgs e)
        {
            isDrawig = true;
            circle = new Circle(new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y), new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y));
            circleForDraw = new System.Windows.Shapes.Ellipse();
            circleForDraw.Stroke = Brushes.Red;
            circleForDraw.SetValue(Canvas.LeftProperty, circle.GetFirstPoint().getX());
            circleForDraw.SetValue(Canvas.TopProperty, circle.GetFirstPoint().getY());
            canvas.Children.Add(circleForDraw);
        }
    }
}
