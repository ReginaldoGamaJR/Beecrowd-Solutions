using System;
using System.Globalization;

class Sphere
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        // Vamos ler o valor do raio e guardar ele na variável R do tipo double.

        double R = double.Parse(Console.ReadLine());

        // Agora vamos calcular o volume utilizando a fórmula V = (4/3) . π . R³

        double volume = (4.0 / 3.0) * 3.14159 * R * R * R;

        // Por fim, vamos imprimir o resultado com 3 casas decimais.

        Console.WriteLine($"VOLUME = {volume:F3}");


    }
}