using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythonConsoleProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to print from python?");
            var input = Console.ReadLine();

            var py = Python.CreateEngine();
            try
            {
                py.Execute("print('From Python: " + input + "')");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                   "Oops! We couldn't print your message because of an exception: " + ex.Message);
            }

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
