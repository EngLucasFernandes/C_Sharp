namespace GeometricForms
{
    internal class Triangle
    {

        public double SideA, SideB, SideC;

        public void GetSides()
        {

            Console.WriteLine("Digite os lados do triângulo: ");
            this.SideA = double.Parse(Console.ReadLine());
            this.SideB = double.Parse(Console.ReadLine());
            this.SideC = double.Parse(Console.ReadLine());

        }

        public double Area()
        {

            double p =  (SideA + SideB + SideC) / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public double Perimeter()
        {

            return SideA + SideB + SideC;

        }

    }
}
