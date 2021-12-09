using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
	class Program
	{
		public static void Main()
		{
			LAB_6 obj = new LAB_6();
			int [] array = new int [] { 23, 24, 2121 };
			int[] array1;
			Console.WriteLine("Введiть потрiбну iнформацiю : ");
			obj.Revers(array, out array1);
		}
	}
}
