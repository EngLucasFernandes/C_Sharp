namespace GeometricForms
{
    internal class Circle
    {

        public double Radius;

        public void GetRadius()
        {

            Console.Write("Digite o raio do círculo: ");
            this.Radius = double.Parse(Console.ReadLine());

        }

        public double Area()
        {

            return Math.PI * Radius * Radius;

        }

        public double Circunference()
        {
            return 2 * Math.PI * Radius;
        }

    }
}
