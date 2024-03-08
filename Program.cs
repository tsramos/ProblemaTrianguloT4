using System;

namespace ProblemaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x;
            x = new Triangulo();
            Triangulo y = new Triangulo();
            
            Console.WriteLine("Informe os lados do triângulo X;");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            Console.WriteLine("Inform os lados do triângulo Y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = CalculoArea(x.A, x.B, x.C);
            double areaY = CalculoArea(y.A, y.B, y.C);

            Console.WriteLine($"Valor area X : {areaX.ToString("F2")}");
            Console.WriteLine($"Valor area Y : {areaY.ToString("F2")}");

            if (areaX > areaY)
            {
                Console.WriteLine("Area de X é maior");
            }
            else 
            {
                Console.WriteLine("Area de Y é maior");
            }
        }

        public static double CalculoArea(double a, double b , double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }
}
