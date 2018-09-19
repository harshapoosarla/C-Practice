using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstuctor
{
    static class AcuvateBank
    {
        static String Bank_account_holder_name;
        public static double Balance;
        static double interest;
        public static double interest_rate = 7.5;
        public static double Total_Balance;
        public static string getBank_account_holder_name()
        {
            Bank_account_holder_name = "Harsha";
            return Bank_account_holder_name;
        }
        public static double getBalance()
        {
            Balance = 100000;
            return Balance;
        }
        public static double getinterest()
        {
            interest = (Balance * interest_rate) / 100;
            return interest;
        }
    }
    class Harsha
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------Acuvate Bank-----------------------");
            Console.WriteLine("Account Holder Name:\n" + AcuvateBank.getBank_account_holder_name());
            Console.WriteLine("Avaliable Balance in Your Account is:\n" + AcuvateBank.getBalance());
            Console.WriteLine("Interest Amount is:\n"+AcuvateBank.getinterest());
           AcuvateBank.Total_Balance = (AcuvateBank.Balance + AcuvateBank.getinterest());
           Console.WriteLine("Total Amount after adding Interest Amount is:\n"+AcuvateBank.Total_Balance);
            Console.ReadLine();
        }
    }
}

