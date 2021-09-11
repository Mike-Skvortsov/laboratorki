using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
	class Program
	{
		//Даний масив розміру N. Перетворити його, вставивши перед (після) кожного додатного (від’ємного) елементу нульовий елемент.
		static void Main()
		{
			int size = 0;
			Console.Write("Введiть розмiр масиву : ");
			size = int.Parse(Console.ReadLine());
			double[] arr = new double [size];
			for (int i = 0; i < size; i++)
			{
				Console.Write(i + 1 + " елемент масиву : ");
				arr[i] = int.Parse(Console.ReadLine());
				if (i > 0 && arr[i - 1] > 0)
				{
					arr[i] = 0;
				}	

			}
			Console.WriteLine("______________________________");
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine(i + 1 + " елемент масиву : " + arr[i]);
			}
		}
	}
}
