using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawingSystem
{
    public class Circle:Shape
    {
        private double radius;
        private string color;


        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Circle():base()
        {

        }

        public Circle(string shapeName, string shapeType, double radius, string color):base(shapeName, shapeType)
        {
            this.shapeName = shapeName;
            this.shapeType = shapeType;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Radius: " + this.radius);
            Console.WriteLine("Color: " + this.color);
        }
    }
}
