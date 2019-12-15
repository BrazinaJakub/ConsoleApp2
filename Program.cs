using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Master = "Fock Off";
            //Console.WriteLine("Hello World! " + Master);
            Kocka k1 = new Kocka("Micka", 5);

            Console.WriteLine("Our cat named {0} is {1} years old!", k1.Name, k1.Age);



            string Master = "Fock Off";
            Console.WriteLine("Hello World! " + Master);

            Console.ReadKey();

        }
    }
}
