using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FigurePaint
{
    class EllipseDrawer:FigureDrawer
    {
        private bool isDrawig = false;
        private Ellipse ellipse;
        private System.Windows.Shapes.Ellipse ellipseForDraw;

        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (isDrawig)
            {
                ellipse.setSecondPoint(new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y));
                if (ellipse.GetSecondPoint().getX() < ellipse.GetFirstPoint().getX())
                    ellipseForDraw.SetValue(Canvas.LeftProperty, ellipse.GetSecondPoint().getX());
                if (ellipse.GetSecondPoint().getY() < ellipse.GetFirstPoint().getY())
                    ellipseForDraw.SetValue(Canvas.TopProperty, ellipse.GetSecondPoint().getY());

                ellipseForDraw.Width = Math.Abs(ellipse.GetFirstPoint().getX() - ellipse.GetSecondPoint().getX());
                ellipseForDraw.Height = Math.Abs(ellipse.GetFirstPoint().getY() - ellipse.GetSecondPoint().getY());
            }
        }
        public override void OnMouseUp(Object sender, MouseEventArgs e)
        {
            isDrawig = false;

        }
        public override void OnMouseDown(Object sender, MouseEventArgs e)
        {
            isDrawig = true;
            ellipse = new Ellipse(new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y), new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y));
            ellipseForDraw = new System.Windows.Shapes.Ellipse();
            ellipseForDraw.Stroke = Brushes.Red;
            ellipseForDraw.SetValue(Canvas.TopProperty,ellipse.GetFirstPoint().getY());
            ellipseForDraw.SetValue(Canvas.LeftProperty, ellipse.GetFirstPoint().getX());
            canvas.Children.Add(ellipseForDraw);
        }
}
}
