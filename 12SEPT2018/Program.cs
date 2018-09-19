using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12SEPT2018
{ 
public class Program
    {
    public static void Main(string[] args)
    {
            try
            {
                Manager Manager1 = new Manager();
                Program P = new Program();
                P.StaffDetails();
                //StaffDetails()
                Salesman Salesman1 = new Salesman();

               

                //Manager Details

                Manager1.ID = 2;
                Manager1.Name = "ABC";
                Manager1.Salary = 20000;
                Manager1.Stock = 50;
                Manager1.HeadOfDept = "Digital Marketing";

                Console.WriteLine("Manager ID:\t" + Manager1.ID);
                Console.WriteLine("Manager Name:\t" + Manager1.Name);
                Console.WriteLine("Manager Salary:\t" + Manager1.CalculateSalary());
                Console.WriteLine("Manager for\t" + Manager1.HeadOfDept + "\tDepartment:");

                //Salesman Details

                Console.WriteLine("\n");
                Salesman1.ID = 3;
                Salesman1.Name = "PQR";
                Salesman1.Location = "Hyderabad";
                Salesman1.Salary = 15000;
                Salesman1.Commission = 500;

                Console.WriteLine("Salesman ID:\t" + Salesman1.ID);
                Console.WriteLine("Salesman Name:\t" + Salesman1.Name);
                Console.WriteLine("Salesman Location:\t" + Salesman1.Location);
                Console.WriteLine("Salesman Salary:\t" + Salesman1.CalculateSalary());
                Console.WriteLine("Total Salary including expenses is:" + Salesman1.SubmitExpenses());
            }

            catch (Exception E2)
            {
                Console.WriteLine("Exception Found in Main method"+E2);
            }
       

        Console.ReadLine();
      }
        public void StaffDetails()
        {
            Staff Staff1 = null;// = new Staff();
            try
            {
                Staff1.ID = 1;
                Staff1.Name = "XYZ";
                Staff1.Salary = 10000;

                Console.WriteLine("Staff ID:\t" + Staff1.ID);
                Console.WriteLine("Staff Name:\t" + Staff1.Name);
                Console.WriteLine("Salary:\t\t" + Staff1.CalculateSalary());
                Console.WriteLine("\n");
            }
            catch (Exception E1)
            {
                Console.WriteLine("Staff Object not created");
                throw E1;
            }
            finally
            {
                Console.WriteLine("Executed");
            }

        }

    }
}

