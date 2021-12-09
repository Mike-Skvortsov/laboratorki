using System;


namespace ConsoleApp1.Entity
{
    internal class second : first
    {
        public second(int number) 
            : base(number)
        {
            Symbols = new string[12] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "*", "#" };
        }

        public new void ReceiveCall()
        {
            Console.WriteLine($"{PhoneNumber} Набраний вами номер");
        }

    }
}
