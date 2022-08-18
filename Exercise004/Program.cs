using System;

namespace Exercise004
{
    class Program
    {
        static void Main(string[] args)
        {
            float number, salary, hours;

            Console.Write("Digite o número do funcionário: ");
            number = float.Parse(Console.ReadLine());

            Console.Write("Digite o salário do funcionário (por hora): ");
            salary = float.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas: ");
            hours = float.Parse(Console.ReadLine());

            salary = salary * hours;

            Console.WriteLine($"Número do funcionário: {number}");
            Console.WriteLine($"Salário final do funcionário: U${salary:F2}");

        }
    }
}
