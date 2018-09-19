using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    class Program
    {
        static void Main1(string[] args)
        {
            var a = 10;
            var b = 10.25;
            var c ="welcome to acuvate";

            Console.WriteLine("Data Type\t\tMemory Allocation\t\tMin Val\t\t\tMax Val");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Char\t\t\t" + sizeof(char) + "\t\t" + char.MinValue + "\t\t\t\t\t" + char.MaxValue);
            Console.WriteLine("Int\t\t\t" + sizeof(int) + "\t\t\t\t" + int.MinValue + "\t\t" + int.MaxValue);
            Console.WriteLine("Short Int\t\t" + sizeof(short) + "\t\t\t\t" +short.MinValue + "\t" + short.MaxValue);
            Console.WriteLine("Long Int\t\t" + sizeof(long) + "\t\t\t\t" + long.MinValue + "\t" + long.MaxValue);
            Console.WriteLine("Double Int\t\t" + sizeof(double) + "\t\t\t\t" + double.MinValue + "\t" + double.MaxValue);
            Console.WriteLine("Float\t\t\t" + sizeof(float) + "\t\t\t\t" + float.MinValue + "\t\t" + float.MaxValue);
            Console.WriteLine("Boolean\t\t\t" + sizeof(bool));



            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");


            Console.WriteLine("value of a is    :"+a);
            Console.WriteLine("value of b is    :"+b);
            Console.WriteLine("value of c is    :"+c);
            Console.WriteLine("value of a+b is  :"+(a+b));
            Console.WriteLine("value of b+c is  :" +(b+c));
            Console.WriteLine("value of a+c is  :" +(a+c));
            Console.WriteLine("value of a+b+c is:" +(a+b+c));
            Console.WriteLine("Size of var data type for integer value is:"+System.Runtime.InteropServices.Marshal.SizeOf(a));
            Console.WriteLine("Size of var data type for float value is:" + System.Runtime.InteropServices.Marshal.SizeOf(b));
            Console.ReadLine();
        }

    }
}
