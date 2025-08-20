using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace structure2
{
    public struct Employee
    {
        private string id;
        private string name;
        private float salary;
        private int age;
        private string designation;

        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public float Salary
        {
            set
            {
                if (value >= 0.0f)
                {
                    this.salary = value;
                }
                else
                {
                    Console.WriteLine("");
                }
            }
        }

        public Employee (string id, string name, float salary, int age, string designation)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.age = age;
            this.designation = designation;
        }

        
    }
}
