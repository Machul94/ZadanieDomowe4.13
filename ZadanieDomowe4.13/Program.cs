using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe4._13
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Program wyświetla FIZZ kiedy liczba jest podzielna przez 3, \nBUZZ kiedy liczb jest podzielna przez 5\nlub FIZZBUZZ jeżeli jest podzielna przez obie z nich.");
            var fizzBuzz = new FizzBuzz();
            while (true)
            {
                Console.WriteLine("Podaj liczbę: ");
                var number = GetNumer();
                Console.WriteLine(fizzBuzz.GetFizzBuzz(number));
                Console.WriteLine();
                Console.WriteLine("Jeżeli chcesz wyjść z aplikacji wciśnij 'X'");
            }
        }
    public static int GetNumer()
    {
        while (true)
        {
                var value = Console.ReadLine();
                if (value.ToUpper() == "X")
                    Environment.Exit(0);
            if (!int.TryParse(value, out int usersNumber))
            {
                Console.WriteLine("Wartość niepoprawna, podaj liczbę całkiwitą.");
                continue;
            }
            return usersNumber;
        }
    }
}
}