using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12SEPT2018
{
    public class Staff : Employee , ICalculateSalary
    {
        string Department { get; set; }

        public float CalculateSalary()
        {
            return Salary;
        }

        //public override float DisplaySalary()
        //{
        //    return Salary;
        //}
    }
}