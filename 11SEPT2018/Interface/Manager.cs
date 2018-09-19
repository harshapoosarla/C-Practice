using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11SEPT2018.Interface
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