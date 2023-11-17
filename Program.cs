using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace GA_ConsoleCrocodile
{
    internal class Program
    {
        
        
        static void Main()
        {
            int i = 0;
            int userPoints = Convert.ToInt32(0);
            int consolePoints = 0;

            while (i < 6)
            {
                Random random = new Random();
                int number1 = Convert.ToInt32(random.Next(0, 10));
                int number2 = Convert.ToInt32(random.Next(0, 10));

                Console.WriteLine();
                Console.WriteLine($"{number1} _ {number2}");
                Console.WriteLine("Hva blir riktig? Velg < / = / > ");
                Console.WriteLine();
                var userInput = Console.ReadLine();
                Console.WriteLine();

                if (number1 < number2 && userInput == "<" ||
                    number1 == number2 && userInput == "=" ||
                    number1 > number2 && userInput == ">")
                {
                    userPoints++; 
                    Console.WriteLine($"Det er riktig! Din poengscore er {userPoints} poeng.");
                }
                else
                {
                    consolePoints++;
                    Console.WriteLine($"Det var feil! Spillet har nå {consolePoints} poeng, mens du har {userPoints}.");
                }

                i++;
                
            }

            Console.WriteLine();
            Console.WriteLine("Game Over!");
            Console.WriteLine($"Poengscore: (deg) {userPoints} - {consolePoints} (spillet)");
            
        }
    }
}