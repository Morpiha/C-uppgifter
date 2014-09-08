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
            double GivenSum = 0.0;

            Console.WriteLine("Ange totalsumma: ");
            sum = double.Parse(Console.ReadLine());

            Console.WriteLine("Erhållet belop: ");
            GivenSum = int.Parse(Console.ReadLine());
        }
    }
}
