using System;
using System.Globalization;

class AgeInDays
{
    static void Main(string[] args)
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Primeiro, lemos o número total de dias

        //Declaramos as variáveis para anos, meses e dias
        int year, month, day;

        int totalDays = int.Parse(Console.ReadLine());

        //Calculamos os anos, meses e dias
        year = totalDays / 365;

        totalDays %= 365;

        month = totalDays / 30;

        day = totalDays % 30;

        //Imprimimos o resultado no formato solicitado
        Console.WriteLine($"{year} ano(s)");

        Console.WriteLine($"{month} mes(es)");

        Console.WriteLine($"{day} dia(s)");

        //Tudo isso em O(1), ou seja, tempo constante, já que não há loops ou recursões.

    }

}