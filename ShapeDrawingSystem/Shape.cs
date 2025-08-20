using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawingSystem
{
    public class Shape
    {
        protected string shapeName;
        protected string shapeType;

        protected static int totalShape;

        public string ShapeName
        {
            get { return this.shapeName; }
            set { this.shapeName = value; }
        }

        public string ShapeType
        {
            get { return this.shapeType; }
            set { this.shapeType = value; }
        }

        public static int TotalShape
        {
            get { return totalShape; }
            set { totalShape = value; }
        }

        public Shape ()
        {

        }

        public Shape(string shapeName, string shapeType)
        {
            this.shapeName = shapeName;
            this.shapeType = shapeType;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine ("Shape Name: "+shapeName);
            Console.WriteLine("Shape Type: " + shapeType);
        }
    }
}
