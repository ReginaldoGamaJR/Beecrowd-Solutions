using System;
using System.Globalization;

class Average1
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine e convertemos para double

        double A = double.Parse(Console.ReadLine());
        
        double B = double.Parse(Console.ReadLine());

        //Calculamos a média ponderada dos dois números

        double average = (A * 3.5 + B * 7.5) / 11.0;

        //Imprimimos o resultado no formato solicitado
        Console.WriteLine($"MEDIA = {average:F5}");


    }
}