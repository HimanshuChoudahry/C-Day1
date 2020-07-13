using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			int factorial=1;
			int number;

			Console.Write("Enter a number :");
			number = Convert.ToInt32(Console.ReadLine());

			while (number > 0)
			{
				factorial = factorial * number;
				number = number-1;
			}
			Console.Write( "The factorial is : " +factorial);
		}
	}
}
