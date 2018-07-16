using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Customer
    {
        public abstract void Print();
        public void Mehtod2()
        {
            Console.WriteLine("Mehtod2");
        }
        public static int MyProperty { get; set; }
    }
    interface IInterface
    {
        int MyProperty1 { get; set; }
        void Imethod();
    }
    class Program : Customer, IInterface
    {
        private int _prop1;
        public int MyProperty1
        {
            get
            {
                if (_prop1 > 0)
                {
                    return _prop1;
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (value != 0)
                {
                    _prop1 = value;
                }
            }
        }

        static void Main(string[] args)
        {
            Customer P = new Program();

            P.Print();
            P.Mehtod2();
            MyProperty = 1;
            //Console.ReadLine();

            IInterface P1 = new Program();
            P1.Imethod();

        }

        public void Imethod()
        {
            Console.WriteLine("Interface method");
        }

        public override void Print()
        {
            Console.WriteLine("Print");
        }
    }
}
