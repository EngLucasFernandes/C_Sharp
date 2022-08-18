using System;

namespace Exercise007
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Digite um número inteiro: ");
            number = int.Parse(Console.ReadLine());

            if(number >= 0)
            {

                Console.WriteLine("O número é não negativo!");
            }
            else
            {

                Console.WriteLine("O número é negativo!");

            }

        }
    }
}
