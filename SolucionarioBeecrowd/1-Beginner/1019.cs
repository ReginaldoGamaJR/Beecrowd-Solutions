using System;
using System.Globalization;

class TimeConversion
{
    static void Main(string[] args)
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine

        //Declaramos as variáveis para horas, minutos e segundos

        int Hours, Minutes, Seconds;

        int TotalSeconds = int.Parse(Console.ReadLine());

        //Calculamos as horas, minutos e segundos

        Hours = TotalSeconds / 3600;

        //Após calcular as horas, pegamos o resto da divisão para calcular os minutos

        TotalSeconds = TotalSeconds % 3600;

        //Calculamos os minutos

        Minutes = TotalSeconds / 60;

        //Após calcular os minutos, pegamos o resto da divisão para calcular os segundos
        Seconds = TotalSeconds % 60;

        //Imprimimos o resultado no formato solicitado

        Console.WriteLine($"{Hours}:{Minutes}:{Seconds}");

        //Tudo isso em O(1), ou seja, tempo constante, já que não há loops ou recursões. 


    }

}