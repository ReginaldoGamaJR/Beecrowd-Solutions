using System;
using System.Globalization;

class Average2
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine e convertemos para double

        double A = double.Parse(Console.ReadLine());

        double B = double.Parse(Console.ReadLine());

        double C = double.Parse(Console.ReadLine());

        //Calculamos a média ponderada dos três números
        double average = (A * 2 + B * 3 + C * 5) / 10.0;

        //Imprimimos o resultado no formato solicitado
        Console.WriteLine($"MEDIA = {average:F1}");

    }
}