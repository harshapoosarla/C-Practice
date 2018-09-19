using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 20,b = 40;
            //Arithmetic operator
            //addition
            Console.WriteLine("addition of a and b is:" + (a + b));
            //substraction
            Console.WriteLine("substraction of a and b is:" + (a - b));
            //multiplication
            Console.WriteLine("multiplication of a and b is:" + (a * b));
            //division
            Console.WriteLine("division of a and b is:" + (a / b));
            //modular
            Console.WriteLine("modular of a and b is:" + (a % b));
            
            //pre increment and post increment
            Console.WriteLine("initial value of a is :" + a);
            Console.WriteLine("preincremented value of a is:" + ++a);
            Console.WriteLine("postincremented value of a is:" + a++);
            Console.WriteLine("final value of a is:" +a);
            //pre decrement and post decrement
            Console.WriteLine("initial value of a is :" + a);
            Console.WriteLine("predecremented value of a is:" + --a);
            Console.WriteLine("postdecremented value of a is:" + a--);
            Console.WriteLine("final value of a is:" + a);
            //Conditional and logical operators
            if (a < b && a > 0)
            {
                Console.WriteLine("a is less than b and a is greater than 0");
            }

            if (a > 0 || a > b)
            {
                Console.WriteLine("a is greater than 0 and a is greater than b");
            }

            if (a == b)
            {
                Console.WriteLine("a is equal to b");
            }

            if (b >= a && b >= 0)
            {
                Console.WriteLine("b is greater than or equal to a and b is greater than or equal to 0");
            }



















            Console.ReadLine();
        }
    }
}
