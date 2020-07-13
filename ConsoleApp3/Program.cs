using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			int number;
			int sum = 0;
			int i;

			Console.Write("Enter the number : ");
			number = Convert.ToInt32(Console.ReadLine());

			while (number > 0)
			{
				i = number % 10;
				sum += i;
				number /= 10;
			}
			Console.Write("Sum of the digits is=" + sum);
		}
	}
}
