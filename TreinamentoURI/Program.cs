using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(" ");

        double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
        double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
        double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

        double delta = Math.Pow(B, 2) - (4 * A * C);

        double R1;
        double R2;

        if (delta >= 0 && A != 0)
        {
            R1 = ((B * -1) + Math.Sqrt(delta)) / (2 * A);
            Console.WriteLine("R1 = " + R1.ToString("F5",CultureInfo.InvariantCulture));
            R2 = ((B * -1) - Math.Sqrt(delta)) / (2 * A);
            Console.WriteLine("R2 = " + R2.ToString("F5",CultureInfo.InvariantCulture));
        }
        else
        {
            Console.WriteLine("Impossivel calcular");

        }
    }
}


/*
 * B * B = 404.1
 * 4 * A * C = 204
 * 
 * DELTA = 200,1
 
 14,14
 */




