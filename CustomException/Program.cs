using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                throw new AlreadyLoggedInException("pritesh error");
            }
            catch (AlreadyLoggedInException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
    [Serializable]
    public class AlreadyLoggedInException : Exception
    {
        public AlreadyLoggedInException() : base()
        {

        }
        public AlreadyLoggedInException(string message) : base(message)
        {

        }
        public AlreadyLoggedInException(string message,Exception innerException) : base(message,innerException)
        {

        }
        public AlreadyLoggedInException(SerializationInfo info, StreamingContext context):base(info,context)
        {

        }
    }
}
