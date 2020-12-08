using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj liczbę: ");
                var number = GetInput();
                FizzBuzz fizzbuzz = new FizzBuzz();
                fizzbuzz.Execute(number);

            }
            catch
            {
                Console.WriteLine("Wprowadzone dane są nieprawidłowe!");

            }

        }
        private static int GetInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int value))
                throw new Exception("Wprowadzone dane są nieprawidłowe!");

            return value;
        }
    }
}
