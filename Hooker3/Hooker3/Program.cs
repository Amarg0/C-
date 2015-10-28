using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hooker3
{
    //Определение типа делегата
    public delegate void FiveHandler();
    public delegate void ThreeHandler();
    public delegate void DigitHandler();
    public delegate void AnyHandler();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome.");
            KeyboardManager km = new KeyboardManager();
            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            //Регистрация обработчиков событий
            km.FivePressed += FiveSubscriber.FiveOn;
            km.ThreePressed += ThreeSubscriber.ThreeOn;
            km.DigitPressed += DigitSubscriber.DigitOn;
            km.AnyPressed += LogSubscriber.AnyOn(ConsoleKeyInfo cki);


            Console.WriteLine("Жми:");
            while (true)
            {
                if (Console.KeyAvailable == true)
                {
                    cki = Console.ReadKey();
                    Console.Clear();
                    if (cki.Key==ConsoleKey.D5)
                    {
                        km.OnFive();
                    }

                    if (cki.Key == ConsoleKey.D3)
                    {
                        km.OnThree();
                    }
                    if (cki.Key==ConsoleKey.D1 || cki.Key==ConsoleKey.D2 ||cki.Key==ConsoleKey.D3 || cki.Key==ConsoleKey.D4||
                        cki.Key==ConsoleKey.D5 || cki.Key==ConsoleKey.D6 || cki.Key==ConsoleKey.D7 || cki.Key==ConsoleKey.D8
                        || cki.Key==ConsoleKey.D9)
                    {
                        km.OnDigit();
                    }
                    if (cki!=null)
                    {
                        km.OnAny(cki);
                    }
                }
            }
        }
    }
}
