using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflaction
{
    class Program
    {
        static void Main(string[] args)
        {
                Type T = Type.GetType("Reflaction.Customer");

            //            Type T = typeof(Customer);

           // Customer C1 = new Customer();
            //Type T = C1.GetType();

            PropertyInfo[] prp = T.GetProperties();
            foreach (var item in prp)
            {
                Console.WriteLine(item.Name);
            }
            MethodInfo[] mtd = T.GetMethods();
            foreach (var item in mtd)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
    public class Customer
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }

        public void MethodA()
        {

        }
    }
}
