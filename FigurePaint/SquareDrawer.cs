using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FigurePaint
{
    class SquareDrawer:FigureDrawer
    {
        private bool isDrawig = false;
        private Square square;
        private System.Windows.Shapes.Rectangle squareForDraw;

        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (isDrawig)
            {
                square.setSecondPoint(new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y));
                if (square.GetSecondPoint().getX() < square.GetFirstPoint().getX())
                {
                    squareForDraw.SetValue(Canvas.LeftProperty, square.GetSecondPoint().getX());
                }
                if (square.GetSecondPoint().getY() < square.GetFirstPoint().getY())
                    squareForDraw.SetValue(Canvas.TopProperty, square.GetSecondPoint().getY());

                squareForDraw.Width = Math.Abs(square.GetFirstPoint().getX() - square.GetSecondPoint().getX());
                squareForDraw.Height = squareForDraw.Width;
               
            }

        }
        public override void OnMouseUp(Object sender, MouseEventArgs e)
        {
            isDrawig = false;
        }
        public override void OnMouseDown(Object sender, MouseEventArgs e)
        {
            isDrawig = true;
            square = new Square(new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y), new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y));
            squareForDraw = new System.Windows.Shapes.Rectangle();
            squareForDraw.Stroke = Brushes.Red;
            squareForDraw.SetValue(Canvas.LeftProperty, square.GetFirstPoint().getX());
            squareForDraw.SetValue(Canvas.TopProperty, square.GetFirstPoint().getY());
            canvas.Children.Add(squareForDraw);
        }
    }
}
