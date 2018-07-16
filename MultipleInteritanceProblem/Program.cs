using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInteritanceProblem
{
    class A
    {
        public virtual void MethodA()
        {

        }
    }
    class B:A
    {
        public override void MethodA()
        {

        }
    }
    class C:A
    {
        public override void MethodA()
        {

        }
    }
    //Compile error
    //class D : B,C
    //{
    //    public override void MethodA()
    //    {

    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
