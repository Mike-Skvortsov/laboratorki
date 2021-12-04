using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para_11._11_
{
	class Garage_dop
	{
		static void Main()
		{
			Garage g = new Garage();
			Car c1 = new Car("first", ConsoleColor.Blue, 400, 1995);
			Car c2 = new Car("favourite", ConsoleColor.Green, 500, 20548);
			Car c3 = new Car("bad", ConsoleColor.Green, 2000, 20548);
			Car c4 = new Car("crash", ConsoleColor.Red, 200, 1587);


			g.AddCar(c1);
			g.AddCar(c2);
			g.AddCar(c3);
			g.AddCar(c4);

			Car OurCar = g.TakeCar(20548);
			ConsoleColor before = Console.BackgroundColor;
			Console.BackgroundColor = OurCar.Color;
			Console.WriteLine(OurCar);
			Console.BackgroundColor = before;

		}
	}
}
