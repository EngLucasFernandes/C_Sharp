using System;
using GeometricForms;

namespace Classes
{

    public class Program
    {

        static void Main()
        {

            string user_choice;

            Menu.ShowMenu();

            Console.Write("Insira uma opção válida: ");
            user_choice = Console.ReadLine();

            while (user_choice != "0" && user_choice != "1" && user_choice != "2" && user_choice != "3")
            {

                Console.WriteLine("Opção inválida!");
                Console.Write("Insira uma opção válida: ");
                user_choice = Console.ReadLine();

            }

            if (user_choice == "1")
            {

                Triangle Triangle = new Triangle();

                Triangle.GetSides();

                Console.WriteLine($"Área do Triângulo: {Triangle.Area():F2}");
                Console.WriteLine($"Perímetro do Triângulo: {Triangle.Perimeter():F2}");

            }
            else if (user_choice == "2")
            {

                Rectangle Rectangle = new Rectangle();

                Rectangle.GetSides();

                Console.WriteLine($"Área do Retângulo: {Rectangle.Area():F2}");
                Console.WriteLine($"Perímetro do Retângulo: {Rectangle.Perimeter():F2}");

            }
            else if (user_choice == "3")
            {

                Circle Circle = new Circle();

                Circle.GetRadius();

                Console.WriteLine($"Área do Círculo: {Circle.Area():F2}");
                Console.WriteLine($"Circunferência do Círculo: {Circle.Circunference():F2}");

            }
            else if (user_choice == "0")
            {

                Console.WriteLine("Até mais!");

            }

        }

    }

}
