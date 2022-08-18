using System;

namespace Exercise001
{
    class Program
    {
        static void Main(string[] args)
        {
            int first_number, second_number, sum;

            Console.Write("Digite o primeiro número inteiro: ");
            first_number = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            second_number = int.Parse(Console.ReadLine());

            sum = first_number + second_number;

            Console.WriteLine($"A soma dos números é: {sum}");

        }
    }
}
