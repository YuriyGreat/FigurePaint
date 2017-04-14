
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace FigurePaint
{
    public partial class MainWindow : Window
    {
        LineDrower lineDrower = new LineDrower();
        TriangleDrawer triangleDrawer = new TriangleDrawer();
        RectangleDrawer rectangleDrawer = new RectangleDrawer();
        EllipseDrawer ellipseDrawer = new EllipseDrawer();
        SquareDrawer squareDrawer = new SquareDrawer();
        CircleDrawer circleDrawer = new CircleDrawer();

        MouseButtonEventHandler mouseDown = null;
        MouseEventHandler mouseMove = null;
        MouseButtonEventHandler mouseUp = null;
        
        public MainWindow()
        {

            InitializeComponent();
        }

        private void ChangeMouseEvents(MouseButtonEventHandler ArgMouseDown, MouseEventHandler ArgMouseMove, MouseButtonEventHandler ArgMouseUp)
        {
            mouseDown = ArgMouseDown;
            mouseMove = ArgMouseMove;
            mouseUp = ArgMouseUp;
        }
        private void AddMouseEvents(Canvas canvas)
        {

            canvas.MouseDown += mouseDown;
            canvas.MouseMove += mouseMove;
            canvas.MouseUp += mouseUp;
        }
        private void RemoveMouseEvents(Canvas canvas)
        {
            try
            {
                canvas.MouseDown -= mouseDown;
                canvas.MouseMove -= mouseMove;
                canvas.MouseUp -= mouseUp;
            }
            catch { }
        }

        private void AddNewFigure(FigureDrawer figureDrawer)
        {
            figureDrawer.setCanvas(canvas);
            RemoveMouseEvents(canvas);
            ChangeMouseEvents(figureDrawer.OnMouseDown, figureDrawer.OnMouseMove, figureDrawer.OnMouseUp);
            AddMouseEvents(canvas);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            RemoveMouseEvents(canvas);
        }
        private void Button_Click_Line(object sender, RoutedEventArgs e)
        {
            AddNewFigure(lineDrower);
        }
        private void Button_Click_Triangle(object sender, RoutedEventArgs e)
        {
            AddNewFigure(triangleDrawer);
        }
        private void Button_Click_Rectangle(object sender, RoutedEventArgs e)
        {
            AddNewFigure(rectangleDrawer);
        }
        private void Button_Click_Square(object sender, RoutedEventArgs e)
        {
            AddNewFigure(squareDrawer);
        }

        private void Button_Click_Ellipse(object sender, RoutedEventArgs e)
        {
            AddNewFigure(ellipseDrawer);
        }

        private void Button_Click_Circle(object sender, RoutedEventArgs e)
        {
            AddNewFigure(circleDrawer);
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
        }
    }
}

