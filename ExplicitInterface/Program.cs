using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
   internal interface I1
    {
      void InterFaceMethod();
    }
    interface I2
    {
        void InterFaceMethod();
    }
    class Program: I1,I2
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            ((I1)P).InterFaceMethod();
            ((I2)P).InterFaceMethod();
            I1 i1 = new Program();
            i1.InterFaceMethod();
            I2 i2 = new Program();
            i2.InterFaceMethod();
            P.InterFaceMethod();

        }

        public void InterFaceMethod()
        {
            Console.WriteLine("Default IMplemenedted");
        }
        void I2.InterFaceMethod()
        {
            Console.WriteLine("IMplemenedted 2");
        }
    }
}
