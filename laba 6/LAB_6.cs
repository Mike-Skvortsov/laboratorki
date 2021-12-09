using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
	class LAB_6
	{
	public int Revers(int num)
	{
		if(num == 0)
		{
			return 0;
		}
		return (num % 10) * Convert.ToInt32(Math.Pow(10, Convert.ToString(num).Length - 1)) + Revers(num/10);
	}


		public string Revers(string word)
		{
			bool with_sign = true;
			string first = "";
			string second = "";
			int count_sign = 0;
			int c = 0;
			while(c < word.Length)
			{
				if(word[c] == ',')
				{
					with_sign = false;
					count_sign = c;
					break;
				}
				c++;
			}
			if (count_sign == word.Length)
				return word;

			if (with_sign)
				return word[word.Length - 1] + Revers(word.Remove(word.Length - 1));
			for (int i = count_sign-1; i >= 0; i--)
				first += word[i];
			
			for (int i = word.Length-1; i > count_sign; i--)
				second += word[i];
			return first + ',' + second;
		}

		public double Revers(double number)
		{
			double frac = (Math.Round(number % 1, 10));
			int fir = Convert.ToInt32(number - number % 1);
			int count = 0;
			while (frac % 1 != 0)
			{
				count++;
				frac *= 10;
			}
			return Revers(fir) + Convert.ToDouble(Revers(Convert.ToInt32(frac))) / Math.Pow(10, count);
		}

		//public void Revers(ref int [] arr)
		//{
		//	int count = arr.Length-1;
		//	int number = 0;
		//	for (int i = 0; i < arr.Length-1; i++)
		//	{
		//		if (((arr.Length - 1) / 2) == count)
		//			break;
		//		number = arr[count];
		//		arr[count] = arr[i];
		//		arr[i] = number;
		//		count--;
		//	}
		//	for(int i = 0; i <= arr.Length - 1; i++)
		//	{
		//		Console.Write(arr[i] + " ");
		//	}
		//}
		public void Revers(int[] arr, out int [] arr1)
		{
			arr1 = new int[arr.Length];
			int count = arr.Length - 1;
			for (int i = 0; i <= arr.Length - 1; i++)
			{
				arr1[i] = arr[count];
				count--;
			}
			for (int i = 0; i <= arr.Length - 1; i++)
			{
				Console.Write(arr1[i] + " ");
			}
		}
	}
}
