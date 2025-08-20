using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure_student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student ();
            std.Id = "201";
            std.Name = "ABCD";
            std.Cgpa = 3.91d;

            std.ShowDetails();

            Student std2 = new Student("202", "MNOP", 2.50d);
            std2.ShowDetails();
        }
    }
}
