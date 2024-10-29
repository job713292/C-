using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el capital inicial:");
        decimal capital = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Ingrese el número de meses:");
        int meses = Convert.ToInt32(Console.ReadLine());

        decimal tasaInteres = 0.007m;

        for (int i = 1; i <= meses; i++)
        {
            capital += capital * tasaInteres;
            Console.WriteLine($"Mes {i}: {capital:C2}");
        }
    }
}

