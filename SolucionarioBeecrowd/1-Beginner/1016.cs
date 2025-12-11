using System;
using System.Globalization;

class Distance
{
    static void Main(string[] args)
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine

        double Distance = double.Parse(Console.ReadLine());

        /*Quando dois carros estão na mesma direção e mesmo sentido, a velocidade relativa entre eles é o módulo da diferença de suas velocidades.
        Neste caso, a velocidade do Carro A é 60 km/h e a do Carro B é 90 km/h. Logo, a velocidade relativa entre os dois carros é: 30Km/h
        Então, para calcular o tempo que o Carro B vai se distanciar do Carro A, uma determina distância, podemos usar a fórmula:
        Tempo = Distância / Velocidade, e quando passarmos para minutos, teremos: Tempo (em minutos) = (Distância / Velocidade) * 60
        Já que a velocidade relativa é 30 km/h, podemos simplificar a fórmula para: Tempo (em minutos) = Distância / 30 * 60 = Distância * 2
        */

        double TimeToDistanceInMinutes = Distance * 2;

        Console.WriteLine($"{TimeToDistanceInMinutes} minutos");

    }

}