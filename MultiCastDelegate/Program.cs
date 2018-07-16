using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    public delegate void sampleDelegate();
    public delegate int sampleDelegate2();
    class Program
    {
        static void Main(string[] args)
        {
            sampleDelegate sd = new sampleDelegate(sampleMethod);
            sd();
            sampleDelegate sd1, sd2, sd3,sd4;
            sd1 = new sampleDelegate(sampleMethod);
            sd2 = new sampleDelegate(sampleMethod2);
            sd3 = new sampleDelegate(sampleMethod3);

            //multicast delegate
            sd4 = sd1 + sd2 + sd3 -sd2;
            sd4();
            
            //another way for multicase delegate
            sampleDelegate del = new sampleDelegate(sampleMethod);
            del += sampleMethod2;
            del += sampleMethod3;
            del -= sampleMethod;
            del();

            //with return value
            sampleDelegate2 rt = new sampleDelegate2(sampleMethod4);
            rt += sampleMethod5;
           int ret= rt();
            Console.WriteLine(ret);
        }
        public static void sampleMethod()
        {
            Console.WriteLine("sample");
        }
        public static void sampleMethod2()
        {
            Console.WriteLine("sample 2");
        }
        public static void sampleMethod3()
        {
            Console.WriteLine("sample 3");
        }
        public static int sampleMethod4()
        {
            return 1;
        }
        public static int sampleMethod5()
        {
            return 2;
        }
    }
}
