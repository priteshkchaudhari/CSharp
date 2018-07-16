using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        public int ID = 1;
        internal int ID2 = 1;
        protected internal int ID3 = 1;

    }
    class AssemblyOneClass2
    {
        AssemblyOneClass1 ins = new AssemblyOneClass1();
        void MethodA()
        {
            ins.ID = 00;
            ins.ID2 = 01;
            ins.ID3 = 003;
        }
    }

    class AssemblyOneClass3: AssemblyOneClass1
    {
        AssemblyOneClass1 ins = new AssemblyOneClass1();
        void MethodA()
        {
            ins.ID = 00;
            ins.ID2 = 01;
            ins.ID3 = 03;
        }
    }
}
