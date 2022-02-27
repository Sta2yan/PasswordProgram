using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string secretMessagePassword = "samurai";
            string secretMessage = "Ура! Вы остановили взрыв.";
            string inputPassword;
            bool isBoom = true;

            while (tryCount-- > 0)
            {
                switch (tryCount)
                {
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        break;
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine("Неверно!");
                        break;
                    case 0:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                        Console.WriteLine("Неверно!");
                        break;
                }

                Console.Write("Введите пароль: ");
                inputPassword = Console.ReadLine();

                if (inputPassword.Equals(secretMessagePassword))
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine(secretMessage);
                    isBoom = false;
                    break;
                }
            }

            if (isBoom)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("БУУУУУУУМ!");
            }
        }
    }
}