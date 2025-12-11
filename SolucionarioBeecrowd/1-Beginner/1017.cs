using System;
using System.Globalization;

class FuelSpent
{
    static void Main(string[] args)
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine

        double TimeSpent = double.Parse(Console.ReadLine());

        double AverageSpeed = double.Parse(Console.ReadLine());

        //Calculamos a quantidade de combustível gasto

        double LitersNeeded = TimeSpent * AverageSpeed / 12;

        //Exibimos o resultado formatado com três casas decimais

        Console.WriteLine(LitersNeeded.ToString("F3"));

    }

}