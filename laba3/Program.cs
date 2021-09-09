using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		//Перевірити істинність вислову: "Дані числа x, у є координатами точки, що лежить у другому квадранті ".
		static void Main()
		{
			float x, y;
			Console.WriteLine("введiть х : ");
			x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("введiть у : ");
			y = Convert.ToInt32(Console.ReadLine());
			if (x <= 0 && y >= 0)
			{
				Console.WriteLine("True");
			}
			else
				Console.WriteLine("False");
		}
	}
}