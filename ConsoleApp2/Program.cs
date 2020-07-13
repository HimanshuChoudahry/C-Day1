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
			int number1;
			int number2;
			int number3;
			int greatest;

			Console.WriteLine("Enter the 1st number : ");
			number1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the 2nd number : ");
			number2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the 3rd number : ");
			number3 = Convert.ToInt32(Console.ReadLine());

			if (number1 > number2)
			{
				greatest = number1;
			}
			else
			{
				greatest = number2;
			}
			if (greatest < number3)
			{
				greatest = number3;
			}

			Console.Write("The greatest number is :" + greatest);
		}
	}
}
