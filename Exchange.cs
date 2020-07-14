using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable1;
            int variable2;
            int exchange;

            Console.Write("Enter the 1st variable : ");
            variable1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the 2nd variable : ");
            variable2 = Convert.ToInt32(Console.ReadLine());

            exchange = variable1;
            variable1 = variable2;
            variable2 = exchange;

            Console.WriteLine("The 1st variable : "+variable1);
            Console.WriteLine("The 2nd variable : "+variable2);
        }
    }
}
