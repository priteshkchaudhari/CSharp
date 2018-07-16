using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            var val = Enum.GetValues(typeof(Gender));
            var nams = Enum.GetNames(typeof(Gender));
        }
    }
    public enum Gender : sbyte
    {
        unknown,
        male,
        female
    }
}
