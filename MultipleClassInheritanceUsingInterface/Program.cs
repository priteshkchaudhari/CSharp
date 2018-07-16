using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClassInheritanceUsingInterface
{
    interface IA
    {
        void MrhodA();
    }
    class A : IA
    {
        public void MrhodA()
        {
            Console.WriteLine("A");
        }
    }
    interface IB
    {
        void MrhodB();
    }

    class B : IB
    {
        public void MrhodB()
        {
            Console.WriteLine("B");
        }
    }
    class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void MrhodA()
        {
            a.MrhodA();
        }

        public void MrhodB()
        {
            b.MrhodB();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.MrhodA();
            ab.MrhodB();
        }
    }
}
