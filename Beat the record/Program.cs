using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beat_the_record
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = 4.5;

            Console.WriteLine(a);
            while (a > 2)
            {
                Console.WriteLine("tijd is nog steeds >2min. try harder!");
                a--;



            }
            Console.Write("Mircea Petrescu - new record " + a);
            Console.ReadLine();
        }
    }
}
