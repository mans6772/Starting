using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starting {
    internal class Program {
        static void Main(string[] args) {
            
            MakeFibonacciSeries();

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
    }
}
