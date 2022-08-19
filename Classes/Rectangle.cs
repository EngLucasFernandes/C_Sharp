namespace GeometricForms
{
    internal class Rectangle
    {

        public double Width, Height;

        public void GetSides()
        {

            Console.Write("Digite a Largura do Retângulo: ");
            this.Width = double.Parse(Console.ReadLine());
            Console.Write("Digite a Altura do Retângulo: ");
            this.Height = double.Parse(Console.ReadLine());

        }

        public double Area()
        {

            return Width * Height;

        }

        public double Perimeter()
        {

            return Width + Width + Height + Height;

        }

    }
}
