using System;

namespace Exercise002
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius, area;

            Console.Write("Digite o raio da circunferência: ");
            radius = float.Parse(Console.ReadLine());

            area = (float) (3.14159 * radius * radius);

            Console.WriteLine($"A área do círculo é: {area:F4}");

        }
    }
}
