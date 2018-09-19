using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Overloading
    {
        protected int a, b, c;
        protected float d, e;
        public Overloading(int a,int b ,int c,float d,float e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }
        virtual public int Add(int a,int b)
        {
            return (a + b);
        }
        virtual public int Add(int a, int b, int c)
        {
            return (a + b + c);
        }
        virtual public float Add(float a, float b)
        {
            return (a + b);
        }
        virtual public string Add(string value1, string value2)
        {
            return (value1 + " " + value2);
        }

    }
    class OverRiding : Overloading
    {

        public OverRiding(int a, int b, int c, float d, float e):base(a,b,c,d,e)
        {
        }
        public void Display()
        {
            Console.WriteLine("Multiplication of two integers:"+ Add(a,b));
            Console.WriteLine("Multiplication of three integers:"+ Add(a,b,c));
           
        }

     public override int Add(int a,int b)
        {
            return a * b;
            //return base.Add(a, b);
        }
        public override int Add(int a, int b, int c)
        {
            return a * b * c;
        }
    
        static void Main(string[] args)
        {
            Overloading objProgram = new Overloading(10,30,50,65.9f,36.4f);
            Console.WriteLine("Adding two integer parameters:" + objProgram.Add(3, 2));
            Console.WriteLine("Adding three integer parameters:" + objProgram.Add(3, 2, 8));
            Console.WriteLine("Adding two float parameters:" + objProgram.Add(3.2f, 22.5f));
            Console.WriteLine("Adding two strings:" + objProgram.Add("hello", "world"));
            OverRiding over = new OverRiding(45,62,91,94.5f,68.1f);
            // Console.WriteLine("Multiplying two integer parameters"  over.Display());

            // Console.WriteLine("Multiplying three integer parameters" + over.);


            over.Display();


            Console.ReadLine();
        }
    }
}
