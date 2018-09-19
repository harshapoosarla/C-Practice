using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11SEPT2018.Interface
{
    public class Salesman : Employee,IInterfaceSubmitExpenses,ICalculateSalary
    {
        public string Location { get; set; }
        public int Commission { get; set; }

        public float CalculateSalary()
        {
            return Salary + Commission;
        }

        //public override float DisplaySalary()
        //{
        //    return Salary + Commission;
        //}

        public float SubmitExpenses()
        {
            return Salary * 2;
        }
    }
}