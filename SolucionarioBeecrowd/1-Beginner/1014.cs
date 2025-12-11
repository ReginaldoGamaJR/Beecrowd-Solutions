using System;
using System.Globalization;

class Consumption
{
    static void Main(string[] args)
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine

        int TotalDistance = int.Parse(Console.ReadLine());

        //Lemos o valor do combustível gasto

        double TotalFuelSpent = double.Parse(Console.ReadLine());

        //Calculamos o consumo médio de combustível

        double AverageConsumption = TotalDistance / TotalFuelSpent;

        //Exibimos o resultado formatado com três casas decimais
        Console.WriteLine($"{AverageConsumption:F3} km/l");

    }

}