using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			double celsius;
			double fahrenheit;

			Console.Write("Enter the temperature in centigrade : ");
			celsius = Convert.ToInt32(Console.ReadLine());

			fahrenheit = celsius * 1.8 + 32;

			Console.Write("The temperature in Fahrenheit :" + fahrenheit);
		}
	}
}
