using AssemblyOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program: AssemblyOneClass1
    {
        static void Main(string[] args)
        {
            Program ins = new Program();
            ins.ID = 2;
            //not allowed
            // ins.ID2 = 01;
            ins.ID3 = 12;
            
            //Not allowed
            //AssemblyOneClass2 ins2 = new AssemblyOneClass2();
        }
    }
}
