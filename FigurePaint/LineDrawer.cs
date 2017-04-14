using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FigurePaint
{
    class LineDrower : FigureDrawer
    {
        private bool isDrawig = false;
        private Line line;
        private System.Windows.Shapes.Line lineToDraw;
        private Point point;
        


        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (isDrawig)
            {
                point = new Point(e.GetPosition(canvas).X, e.GetPosition(canvas).Y);
                line.setSecondPoint(point);

                lineToDraw.X2 = line.GetSecondPoint().getX();
                lineToDraw.Y2 = line.GetSecondPoint().getY();
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
            line = new Line(point, point);
            lineToDraw = new System.Windows.Shapes.Line();

            lineToDraw.X1 = lineToDraw.X2 = line.GetSecondPoint().getX();
            lineToDraw.Y1 = lineToDraw.Y2 = line.GetSecondPoint().getY();
            lineToDraw.Stroke = Brushes.Red;
            canvas.Children.Add(lineToDraw);
        }
    }
}
