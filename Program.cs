using System;

namespace ProblemaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Informe os lados do triângulo X;");
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());
            Console.WriteLine("Inform os lados do triângulo Y");
            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            double areaX = CalculoArea(xA, xB, xC);
            double areaY = CalculoArea(yA, yB, yC);

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
