using System;
using System.Globalization;

class SimpleSum
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Agora por padrão, na maioria dos problemas vou manter o uso do DefaultThreadCurrentCulture para garantir a consistência na leitura e escrita de números.

        //Lemos os valores de entrada utilizando o Console.ReadLine e convertemos para inteiro

        int N1 = int.Parse(Console.ReadLine());

        int N2 = int.Parse(Console.ReadLine());

        //Calculamos a soma dos dois números
        int sum = N1 + N2;

        //Imprimimos o resultado no formato solicitado
        Console.WriteLine($"SOMA = {sum}");


    }
}