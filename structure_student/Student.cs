using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace structure_student
{
    struct Student
    {
        private string id;
        private string name;
        private double cgpa;
        private static int c;

        public string Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }

        public double Cgpa
        {
            set
            {
                this.cgpa = value;
            }
            get
            {
                return this.cgpa;
            }
        }

        public Student(string id, string name, double cgpa)
        {
            this.id = id;
            this.name = name;
            this.cgpa = cgpa;
            c++;
        }

        /*
        public void SetId (string id)
        {
            this.id = id;
        }

        public string GetId ()
        {
            return this.id;
        }
        */

        public void ShowDetails ()
        {
            Console.WriteLine("STUDENT INFORMATION : "+c);
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("NAME: " + this.name);
            Console.WriteLine("CGPA: " + this.cgpa);

        }
    }
}
