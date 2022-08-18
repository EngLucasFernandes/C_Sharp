using System;

namespace Exercise003
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine($"Diferença: {(a * b) - (c * d)}");

        }
    }
}
