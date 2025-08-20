using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Shape Objects ===");

            // Shape 1: default constructor + manual property setting
            Shape shape1 = new Shape();
            shape1.ShapeName = "Polygon";
            shape1.ShapeType = "Abstract";
            shape1.ShowDetails();

            // Shape 2: parameterized constructor
            Shape shape2 = new Shape("Hexagon", "Polygon");
            shape2.ShowDetails();

            Console.WriteLine("\n=== Rectangle Objects ===");

            // Rectangle 1: default constructor + manual property setting
            Rectangle rect1 = new Rectangle();
            rect1.Length = 5;
            rect1.Width = 5;
            rect1.ShowDetails();

            // Rectangle 2: parameterized constructor
            Rectangle rect2 = new Rectangle("MyRectangle", "Quadrilateral", 8, 4);
            rect2.ShowDetails();

            Console.WriteLine("\n=== Circle Objects ===");

            // Circle 1: default constructor + manual property setting
            Circle circle1 = new Circle();
            circle1.Radius = 15;
            circle1.Color = "Red";
            circle1.ShowDetails();

            // Circle 2: parameterized constructor
            Circle circle2 = new Circle("MyCircle", "Ellipse", 7, "Blue");
            circle2.ShowDetails();

            Console.WriteLine($"\n=== Total Shapes Created: {Shape.TotalShape} ===");
        }
    }
    }
