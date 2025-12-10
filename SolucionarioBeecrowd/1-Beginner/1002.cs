using System;
using System.Globalization;

class AreaOfACircle
{
    static void Main(string[] args)
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Vou utilizar o DefaultThreadCurrentCulture para garantir que o ponto será utilizado como separador decimal.
        //Ele precisado using System.Globalization;

        //Vamos ler o valor do raio e guardar ele na variável R do tipo double.

        double R = double.Parse(Console.ReadLine());

        //Agora vamos calcular a área utilizando a fórmula A = π . R²

        double area = 3.14159 * R * R;

        //Por fim, vamos imprimir o resultado com 4 casas decimais.
        Console.WriteLine($"A={area:F4}");
    }
}