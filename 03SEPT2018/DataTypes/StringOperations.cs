using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    class StringOperations
    {
        static void Main(string[] args)
        {
            // concatination of strings
            string str1 = "welcome to acuvate";
            string str2 = "C# Introduction";
            string str3 = string.Concat(str1,str2);
            Console.WriteLine("string after concatenation :"+str3);
            //ToUpper conversion
            str3 = str3.ToUpper();
            Console.WriteLine("string after converting ToUpper:"+str3);
            //ToLower conversion
            string str4 = "WELCOME TO ACUVTAE";
            str4 = str4.ToLower();
            Console.WriteLine("string after converting ToLower:"+str4);
            // Trim Function
            string str5 = "            today is holiday       ";
            str5 = str5.Trim();
            Console.WriteLine("string after trim operation:"+str5);
            //contains function
            bool iscontains = str1.Contains("acuvate");
            Console.WriteLine(iscontains);
            //ToCharArray conversion
            Console.WriteLine("ToCharArray of str1 is:");
            char[] charArray = str1.ToCharArray();
            foreach (char c in charArray)
            {
                Console.WriteLine(c);
            }
            //Substring
            str1 = str1.Substring(0, 8);
            Console.WriteLine("sub-string of given string is:"+str1);
            //startswith
            bool iscontains1 = str1.StartsWith("welcome");
            Console.WriteLine(iscontains);
            //split function
            string str = "my-name-is-harsha";
            string[] breakMysentence = str.Split('-');
            foreach (string data in breakMysentence)
                Console.WriteLine(data);
            //replace string in string
            string str6 = "welcme to acurate";
            string str7 = str6.Replace("acurate", "acuvate");
            Console.WriteLine("string after replacing"+str7);
            //clone function
            string str8 = (string)str.Clone();
            Console.WriteLine("string after clone operation:"+str8);
            //trim end
            string str9 = "           hi this is harsha          ";
            Console.WriteLine("string after trim operation applied at end is:"+str9.TrimEnd());
            //trim start
            string str10 = "           hi this is harsha          ";
            Console.WriteLine("string after trim operation applied at start is:" + str10.TrimStart());
            //hashcode function
            string str11 = "harsha";
            Console.WriteLine("hashcode of str11 is:" + str11.GetHashCode());
            //gettype function
            Console.WriteLine("gettype of str11 is:" + str11.GetType());





            Console.ReadLine();

        }
    }
}
