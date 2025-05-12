using System;

namespace Starting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GuessTheNumber();
            //MakeFibonacciSeries();

        }

        private static void MakeFibonacciSeries()
        {
            int n = 10;
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
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
            int minRenge , maxRenge;
            Console.Write("hadeaghal adad baraye mahdodeh ra vared konid");
            while(!int.TryParse(Console.ReadLine(), out minRenge)) ;
          
            Console.Write("hade aksar adade baraye mahdodeh ra vared konid");
            while (!int.TryParse(Console.ReadLine(),out maxRenge) || maxRenge <= minRenge)
            {
                Console.Write("vorodi na motabar ast bayad bozorg tar az hadeaghal bashad dobareh vared konid");
            }
            int SecretNumber = random.Next(minRenge,maxRenge + 1);
            Console.WriteLine("yek adad beyne {minRange} ta {maxRenge} entekhab shodeh ast");



            string attemptsInput = Console.ReadLine();
            int maxAttempts;
            while (!int.TryParse(attemptsInput, out maxAttempts) || maxAttempts < 1 || maxAttempts > 15)
            {
                Console.Write("vorodi namotabarhastbeyn adade 1ta 15 entekhab konid: ");
                attemptsInput = Console.ReadLine();
            }

            bool win = false;

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.Write($"hadse shomare {attempt}: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("adadehvorodinamotabar hast  faghat adadeh sahih vared konid.");
                    attempt--;  
                    continue;
                }

                if (guess ==SecretNumber)
                {
                    Console.WriteLine("adadeh vared shodeh sahih ast shoma barandeh shodid!");
                    win = true;
                    break;
                }
                else if (guess < SecretNumber)
                {
                    Console.WriteLine("adadeh varedh shodeh kochektar ast az adadeh moredeh nazar.");
                }
                else
                {
                    Console.WriteLine("adadeh varedshodeh bozrg tar aza dadeh mordeh nazar ast.");
                }
            }

            if (!win)
            {
                Console.WriteLine($"moteastefam shoma natavanestin adadehdorost ra hasbezanin: {SecretNumber}");
            }

            Console.WriteLine("baray khoroj kilidira feshar dahid...");
            Console.ReadKey();
        }
    }
}
