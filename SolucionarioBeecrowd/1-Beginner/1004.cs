using System;
using System.Globalization;

class SimpleProduct
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine e convertemos para inteiro

        int N1 = int.Parse(Console.ReadLine());

        int N2 = int.Parse(Console.ReadLine());

        //Calculamos o produto dos dois números

        int product = N1 * N2;

        //Imprimimos o resultado no formato solicitado
        Console.WriteLine($"PROD = {product}");

    }
}