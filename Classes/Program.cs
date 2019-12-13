using System;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            //intanciando CLASS
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //utilizando Método AREA
            double areaX = x.Area();
            double areaY = y.Area();

            ////calcula da area do triangulo X
            //double p = (x.A + x.B + x.C) / 2.0;
            //double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            ////calcula da area do triangulo Y
            //p = (y.A + y.B + y.C) / 2.0;
            //double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            //exibindo as areas
            Console.WriteLine("Area do Triangulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do Triangulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //qual é o maior
            if (areaX > areaY)
            {
                Console.WriteLine("Maior Area é do X");
            }
            else
            {
                Console.WriteLine("Maior Area é do Y");
            }

            // exemplo padrao
            //double xA, xB, xC, yA, yB, yC;

            //Console.WriteLine("Entre com as medidas do triangulo X:");
            //xA = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xB = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xC = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triangulo Y:");
            //yA = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ////calcula da area do triangulo X
            //double p = (xA + xB + xC) / 2.0;
            //double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            ////calcula da area do triangulo Y
            //p = (yA + yB + yC) / 2.0;
            //double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            ////exibindo as areas
            //Console.WriteLine("Area do Triangulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Area do Triangulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            ////qual é o maior
            //if( areaX > areaY)
            //{
            //    Console.WriteLine("Maior Area é do X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior Area é do Y");
            //}
        }
    }
}
