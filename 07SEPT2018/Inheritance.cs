using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class PersonalInformation
    {

        private int age;
        private string address;
        private static DateTime dOB;
        private string name;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        protected DateTime DOB
        {
            get
            {
                return dOB;
            }
            set
            {
                value = dOB;
            }
        }

        protected PersonalInformation(string Name, string Address, string DOB1)
        {
            this.Name = Name;
            this.Address = Address;
            dOB = NewMethod(DOB1);
            Age = NewMethod1();
        }

        private int NewMethod1()
        {
            return CalculateAge(DOB);
        }

        private static DateTime NewMethod(string DOB1)
        {
            return Convert.ToDateTime(DOB1);
        }

        int CalculateAge(DateTime DOB1)
        {
            DOB = (DOB1);
            Age = DateTime.Now.Year - DOB.Year;
            return Age;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Address:" + Address);
            Console.WriteLine("Date of Birth:" + DOB);
            Console.WriteLine("Age:" + Age);
        }
        public void DisplayDetails(string gender)
        {

        }

        //class Subjects
        //{
        //    string subjects;
        //}

        class Student : PersonalInformation
        {
            int Grade;
            public float Percentage;

            public Student(int Grade, float Percentage, string Name, string Address, string DOB) : base(Name, Address, DOB)
            {
                this.Grade = Grade;
                this.Percentage = Percentage;
            }
            public void DisplayExtraDetails()
            {
                Console.WriteLine("Grade:" + Grade);
                Console.WriteLine("Percentage:" + Percentage);
            }
        }
        class Program
        {
            static void Main1(string[] args)
            {
                Student s1 = new Student(1, 82, "Harsha", "Visakhapatnam", "04/26/1997");
                s1.DisplayDetails();
                s1.DisplayExtraDetails();
                Console.ReadKey();
            }
        }
    }
}