using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsAnd__
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Create two equal but distinct strings
                string a = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });
                string b = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });

                Console.WriteLine(a == b);
                Console.WriteLine(a.Equals(b));

                // Now let's see what happens with the same tests but
                // with variables of type object
                object c = a;
                object d = b;

                Console.WriteLine(c == d);
                Console.WriteLine(c.Equals(d));

            }
        }
    }
}
