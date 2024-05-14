using System;
using GuessNumber.Controller;

namespace GuessNumber 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Вас приветствует игра ""Угадай число""");
            Console.Write("Укажите ваше имя.");
            var name = Console.ReadLine();
            Console.Write("Укажите вашу электронную почту.");
            var email = Console.ReadLine();
           
            var userController = new UserController(new NameValidator(), new EmailValidator());
            userController.UserCreate(name, email);
            
            Console.Write("Введите количество попыток: ");
            var tryCount = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальное число: ");
            var maxNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите минимальное число: ");
            var minNumber = int.Parse(Console.ReadLine());
            CheckNumber(tryCount, minNumber, maxNumber);
        }

        public static void CheckNumber(int tryCount, int minRange, int maxRange)
        {
            Random rmd = new Random();
            int randomNumber = rmd.Next(minRange, maxRange);
            while (tryCount > 0)
            {
                Console.Write("Введите число: ");
                var number = int.Parse(Console.ReadLine());
                if (number > randomNumber)
                {
                    Console.WriteLine("Введенное вами число больше загаданного.");
                }

                if (number < randomNumber)
                {
                    Console.WriteLine("Введенное вами число меньше загаданного.");
                }

                if (number.Equals(randomNumber))
                {
                    Console.WriteLine("Указанное число совпадает!");
                    break;
                }

                tryCount--;
            }
        }

    }
}