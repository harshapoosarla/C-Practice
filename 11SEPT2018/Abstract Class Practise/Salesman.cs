using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11SEPT2018.AbstractClassPractise
{
   public class Salesman:Employee
    {
        public string Location{ get ; set; }
        public int Commission { get; set; }

        public override float DisplaySalary()
        {
            return Salary + Commission;
        }
    }
}
