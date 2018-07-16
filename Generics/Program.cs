using System;


namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool equal = Calculator.AreEqual(4, 4);
            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            bool equal2 = Calculator.AreEqual("sf", "sf3");
            if (equal2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
    public class Calculator
    {
        public static bool AreEqual<T2>(T2 val1, T2 val2)
        {
            return val1.Equals(val2);
        }
    }
}
