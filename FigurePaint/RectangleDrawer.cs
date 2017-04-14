using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FigurePaint
{
    class RectangleDrawer:FigureDrawer
    {
        private bool isDrawig = false;
        private Rectangle rectagle;
        private System.Windows.Shapes.Rectangle rectangleForDraw;

        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (isDrawig)
            {
                rectagle.setSecondPoint(new Point(e.GetPosition(canvas).X,e.GetPosition(canvas).Y));
                if (rectagle.GetSecondPoint().getX() < rectagle.GetFirstPoint().getX())
                    rectangleForDraw.SetValue(Canvas.LeftProperty, rectagle.GetSecondPoint().getX());
                if (rectagle.GetSecondPoint().getY() < rectagle.GetFirstPoint().getY())
                    rectangleForDraw.SetValue(Canvas.TopProperty, rectagle.GetSecondPoint().getY());
                
                rectangleForDraw.Width = Math.Abs(rectagle.GetFirstPoint().getX()- rectagle.GetSecondPoint().getX());
                rectangleForDraw.Height = Math.Abs(rectagle.GetFirstPoint().getY() - rectagle.GetSecondPoint().getY());
            }

        }
        public override void OnMouseUp(Object sender, MouseEventArgs e)
        {
            isDrawig = false;
        }
        public override void OnMouseDown(Object sender, MouseEventArgs e)
        {
            rectagle = new Rectangle(new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y), new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y));
            isDrawig = true;

            rectangleForDraw = new System.Windows.Shapes.Rectangle();
            rectangleForDraw.Stroke = Brushes.Red;
            rectangleForDraw.SetValue(Canvas.LeftProperty, rectagle.GetFirstPoint().getX());
            rectangleForDraw.SetValue(Canvas.TopProperty, rectagle.GetFirstPoint().getY());
            canvas.Children.Add(rectangleForDraw);
        }
    }
}
