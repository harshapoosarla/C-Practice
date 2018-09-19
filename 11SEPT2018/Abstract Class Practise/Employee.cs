using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _11SEPT2018.AbstractClassPractise
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public abstract float DisplaySalary();
    }
}
