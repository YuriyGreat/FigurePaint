using System;
using System.Windows.Controls;
using System.Windows.Input;


namespace FigurePaint
{
    abstract class FigureDrawer : Canvas
    {

        protected Canvas canvas;

        public void setCanvas(Canvas canvas)
        {
            this.canvas = canvas;
        }

        public abstract void OnMouseMove(Object sender, MouseEventArgs e);
        public abstract void OnMouseUp(Object sender, MouseEventArgs e);
        public abstract void OnMouseDown(Object sender, MouseEventArgs e);
    }
}
