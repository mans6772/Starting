using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starting {
    internal class Program {
        static void Main(string[] args) {

            GuessTheNumber();
            //MakeFibonacciSeries();

        }

        private static void MakeFibonacciSeries() {
            int n = 10;
            int a = 0, b = 1;
            for (int i = 0; i < n; i++) {
                Console.WriteLine(a);
                int temp = a + b;
                a = b;
                b = temp;
            }

            Console.WriteLine("");
            Console.WriteLine("Mission Completed !");
            Console.WriteLine("");
            Console.WriteLine("Press any key to Exit");

            Console.ReadKey();

            Environment.Exit(0);
        }

        private static void GuessTheNumber()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 1001);
            int maxAttempts = 10;

            Console.WriteLine("yek adad bin 1 ta 1000 entekhab shodeh ast.");
            Console.WriteLine("shoma 10 martabeh forsat darid ta an ra hads bezanid.");

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.Write($"حدس {attempt}: ");
                string input = Console.ReadLine();


                if (int.TryParse(input, out int guess))
                {
                    if (guess == secretNumber)
                    {
                        Console.WriteLine("dorost vard kardid barandeh shodid!");
                        Console.ReadKey();
                        return;
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("adadeh vard shodeh kuchekter az adadi keh hast.");
                    }
                    else
                    {
                        Console.WriteLine("adadeh vard shodeh bozorgtar az adadi keh hast.");
                    }
                }
                else
                {
                    Console.WriteLine("adadeh vorodi namotabar ast! faghat kafist vard konid.");
                    attempt--;
                }
            }

            Console.WriteLine($"mofegh neshodid. moord nazar {secretNumber} bod.");
            Console.WriteLine("baraye khoroj kilidi ra feshar dahid.");
            Console.ReadKey();
        }

    }
}
