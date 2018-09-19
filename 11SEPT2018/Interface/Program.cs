using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11SEPT2018.Interface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Manager Manager1 = new Manager();
            Staff Staff1 = new Staff();
            Salesman Salesman1 = new Salesman();


            Staff1.ID = 1;
            Staff1.Name = "Harsha";
            Staff1.Salary = 10000;

            Console.WriteLine("Staff ID:\t" + Staff1.ID);
            Console.WriteLine("Staff Name:\t" + Staff1.Name);
            Console.WriteLine("Salary:\t\t" + Staff1.CalculateSalary());
            Console.WriteLine("\n");

            Manager1.ID = 2;
            Manager1.Name = "Harsha";
            Manager1.Salary = 20000;
            Manager1.Stock = 50;
            Manager1.HeadOfDept = "Digital Marketing";

            Console.WriteLine("Manager ID:\t" + Manager1.ID);
            Console.WriteLine("Manager Name:\t" + Manager1.Name);
            Console.WriteLine("Manager Salary:\t" + Manager1.CalculateSalary());
            Console.WriteLine("Manager for\t" + Manager1.HeadOfDept + "\tDepartment:");

            Console.WriteLine("\n");
            Salesman1.ID = 3;
            Salesman1.Name = "Harsha";
            Salesman1.Location = "Hyderabad";
            Salesman1.Salary = 15000;
            Salesman1.Commission = 500;
            
            Console.WriteLine("Salesman ID:\t" + Salesman1.ID);
            Console.WriteLine("Salesman Name:\t" + Salesman1.Name);
            Console.WriteLine("Salesman Location:\t" + Salesman1.Location);
            Console.WriteLine("Salesman Salary:\t" + Salesman1.CalculateSalary());
            Console.WriteLine("Total Salary including expenses is:" + Salesman1.SubmitExpenses());

            Console.ReadLine();
        }
    }
}
