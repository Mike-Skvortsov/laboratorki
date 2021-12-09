using System;


namespace ConsoleApp1.TaskAboutPhones
{
    internal class third : second 
    {
        protected float resolution;
        protected double sizeScreen;
        protected string color;

        protected float Resolution { get => resolution; set => resolution = value; }
        protected double SizeScreen { get => sizeScreen; set => sizeScreen = value; }
        protected string Color { get => color; set => color = value; }

        public third(int number,float resolution, double sizeScreen, string color)
            : base(number)
        {
            Resolution = resolution;
            SizeScreen = sizeScreen;
            Color = color;
        }

        public void SendSMS(string sms)
        {
            Console.WriteLine("Вiдправлене повiдомлення: " + sms);
        }

        public void ReceiveSMS()
        {
            Console.WriteLine("Отримати повiдомлення");
        }


    }
}
