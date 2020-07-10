using System;
using System.Dynamic;

namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prima uma tecla");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
			    Console.WriteLine("Indique um número:");
			    double n1 = int.Parse(Console.ReadLine()); 
			    Console.WriteLine("Indique a operação que quer realizar:");
			    ConsoleKeyInfo k = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Indique outro número:");
			    double n2 = int.Parse(Console.ReadLine());  

			    double res = Calcular(k,n1,n2) ;
			    Console.WriteLine(@"O resultado é {0}",res);
			    //Console.WriteLine("O resultado é:" + res);
			    //Console.ReadKey();
             };
        }
        static double Calcular(ConsoleKeyInfo k, double n1, double n2)
        {
            double res = 0;
            if (k.Key == ConsoleKey.Add)
                res = n1 + n2;
            if (k.Key == ConsoleKey.Subtract)
                res = n1 - n2;
            if (k.Key == ConsoleKey.Divide)
                res = n1 / n2;
            if (k.Key == ConsoleKey.Multiply)
                res = n1 * n2;

            return res;
        }
    }
}
