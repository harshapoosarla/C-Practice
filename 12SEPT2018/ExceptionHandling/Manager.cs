using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12SEPT2018
{
    public class Manager : Employee,ICalculateSalary
    {
        public string HeadOfDept { get; set; }
        public int Stock { get; set; }

        public float CalculateSalary()
        {
            return Salary + (Stock * 10);   
        }
        //public override float DisplaySalary()
        //{
        //    return Salary + (Stock * 10);
        //}
    }
}