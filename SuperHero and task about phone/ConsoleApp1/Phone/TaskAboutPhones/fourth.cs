using System;


namespace ConsoleApp1.Entity
{
    internal class fourth : third
    {
        protected int numberColor;
        protected bool isTwoSimCard;
        protected int secondNumber;

        protected int NumberColor { get => numberColor; set => numberColor = value; }
        protected bool IsTwoSimCard { get => isTwoSimCard; set => isTwoSimCard = value; }
        protected int SecondNumber { get => secondNumber; set => secondNumber = value; }

        public fourth(int number, int numberColor, bool isTwoSimCard, int secondNumber,
           float resolution, double sizeScreen, string color)
           : base(number, resolution, sizeScreen, color)
        {
            NumberColor = numberColor;
            IsTwoSimCard = isTwoSimCard;
            SetSecondNumber(secondNumber);
            Symbols = new string[15] { "1", "2", "3", "4", "5",
                "6", "7", "8", "9", "0", "*", "#", "!", "-", "+" };
        }

        public void SetSecondNumber(int secondNumber)
        {
            if (isTwoSimCard)
            {
                SecondNumber = secondNumber;
            }
            else
                Console.WriteLine("Ви маєте тільки 1 сiм карту");
        }

        public void SendMMS(string sms)
        {
            Console.WriteLine("Відправлене mms: " + sms);
        }

        public void ReceiveMMS()
        {
            Console.WriteLine("Нова mms!");
        }

    }

}
