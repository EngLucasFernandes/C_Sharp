using System;

namespace Exercise008
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Digite um número inteiro: ");
            number = int.Parse(Console.ReadLine());

            if(number % 2 == 0)
            {

                Console.WriteLine("Número par!");

            }
            else
            {

                Console.WriteLine("Número ímpar!");

            }

        }
    }
}
