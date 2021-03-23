using System;

namespace pc_etec1b_projeto_soma
{
    class Program
    {
        static void Main(string[] args)
        { 
            int nr1 = 0, nr2 = 0, total = 0;

            Console.WriteLine("digite o primeiro numero");
            nr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            nr2 = Convert.ToInt32(Console.ReadLine());

            total = nr1 + nr2;

            Console.WriteLine("o total da soma é "+total);
            Console.ReadKey();
        }
    }
}
