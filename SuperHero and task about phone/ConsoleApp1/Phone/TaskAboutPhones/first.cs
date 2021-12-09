using System;


namespace ConsoleApp1.Entity
{
    internal class first
    {
        protected int phoneNumber;

        protected string[] Symbols = null;
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string[] Symbols { get => Symbols; set => Symbols = value; }


        public first(int number)
        {
            PhoneNumber = number;
            Symbols = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        }

        public void Call()
        {
            Console.WriteLine("Набраний вами номер");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Номер, який вам зателефонував");
        }


    }
}
