using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class AppException : Exception
    {
        public AppException(String message) : base(message)
        {
        }

        public AppException(String message, Exception inner) : base(message, inner) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {


                try
                {
                    Console.WriteLine("Enter a number");
                    int sdd = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(streamReader.ReadToEnd());

                }
                catch (Exception ex)
                {
                    throw new Exception("errror", ex);
                    //streamReader = new StreamReader(@"C:\sample1\test.txt");
                    //Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            //block will always excute
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }
    }
}
