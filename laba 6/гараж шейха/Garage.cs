using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para_11._11_
{
	class Garage
	{
		List<Car> cars;
		public Garage()
		{
			cars = new List<Car>();
		}
		public void AddCar(Car c)
		{
			this.cars.Add(c);
		}
		public void DeleteCar(Car c)
		{
			this.cars.Remove(c);
		}
		//public Car GetCar(string name)
		//{

		//}
		public Car TakeCar(string name)
		{
			for (int i = 0; i < this.cars.Count; i++)
			{
				if(name == this.cars[i].Name)
				{
					return this.cars[i];
				}
			}
			Console.WriteLine("404, You take first car!");
			return cars[0];
		}
		public Car TakeCar(ConsoleColor color)
		{
			for (int i = 0; i < this.cars.Count; i++)
			{
				if (color == this.cars[i].Color)
				{
					return this.cars[i];
				}
			}
			Console.WriteLine("404, You take first car!");
			return cars[0];
		}
		public Car TakeCar(short year)
		{
			if (year >= 1600)
			{
				for (int i = 0; i < this.cars.Count; i++)
			{
				if (year == this.cars[i].Year)
				{
					return this.cars[i];
				}
			}
		}
			else { 
			for (int i = 0; i < this.cars.Count; i++)
			{
				if (year == this.cars[i].MaxSpeed)
				{
					return this.cars[i];
				}
			}
		}
			Console.WriteLine("404, You take first car!");
			return cars[0];
		}
		public void ShowCars()
		{
			ConsoleColor before = Console.BackgroundColor;
			for(int i = 0; i < this.cars.Count;i++)
			{
				Console.BackgroundColor = this.cars[i].Color;
				Console.Write(this.cars[i].ToString());
			}
			Console.BackgroundColor = before;
		}
	}
}
