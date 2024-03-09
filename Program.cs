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

            double areaX = x.CalculoArea();
            double areaY = y.CalculoArea();

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
    }
}
