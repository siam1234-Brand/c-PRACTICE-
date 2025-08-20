using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawingSystem
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;


        public double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public Rectangle():base()
        {

        }

        public Rectangle(string shapeName, string shapeType, double length, double width): base (shapeName, shapeType)
        {
            this.length = length;
            this.width = width;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: " + width);
        }

        public bool Issquare()
        {
            if (length == width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetPerimeter()
        {
            double perimeter = 2 * (this.length + this.width);
            return perimeter;
        }

        public string GetPerimeter(string unit)
        {
            return ("Perimeter: " +unit +" cm");
        }
    }
}
