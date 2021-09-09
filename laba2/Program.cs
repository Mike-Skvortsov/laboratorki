using System;

namespace lab2
{
    class HelloWorld
    {
        //lab2
        static void Main()
        {
            int nk;
            int nn;
            double a;
            double result = 1;
            do
            {
                Console.WriteLine("input nn : ");
                nn = Convert.ToInt32(Console.ReadLine());
            } while (nn <= 0);
            do
            {
                Console.WriteLine("input nk : ");
                nk = Convert.ToInt32(Console.ReadLine());
            } while (nk <= nn);
            double k = nn;
            for (int i = nk; i >= nn; i--)
            {
                a = 0;
                a = (Math.Pow(-1, k) * Math.Pow(k, 2) + Math.Pow(-1, (Math.Pow(k, 2) + 1)) * k) / (2 * (Math.Pow(k, 3) + 3));
                result *= a;
                if (k <= nk)
                {
                    k++;
                }
            }
            Console.WriteLine(result);
        }
    }
}