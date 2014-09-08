using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;
            int GivenSum = 0;

            Console.Write("Ange totalsumma:");
            sum = double.Parse(Console.ReadLine());

            Console.Write("Erhållet belop:");
            GivenSum = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("KVITTO");

        }
    }
}
