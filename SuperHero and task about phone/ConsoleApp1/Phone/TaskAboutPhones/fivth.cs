using System;


namespace ConsoleApp1.Entity
{
    internal class fivth : fourth
    {
        public void Photo()
        {
            Console.WriteLine("Створення фото");
        }

        public void Video()
        {
            Console.WriteLine("Створення вiдео");
        }

        public fivth(int number, int numberColor, bool isTwoSimCard, int secondNumber,
            float resolution, double sizeScreen, string color)
            : base (number,numberColor,isTwoSimCard,secondNumber,resolution,sizeScreen,color)
        {
            Symbols = new string[15] { "1", "2", "3", "4", "5",
                "6", "7", "8", "9", "0", "*", "#", "!", "-", "+" };
        }
    }
}
