using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11SEPT2018.AbstractClassPractise
{
    public class Manager:Employee
    {
        public string HeadOfDept { get; set; }
        public int Stock { get ; set; }

        public override float DisplaySalary()
        {
            return Salary + (Stock * 10);
        }
    }
}
