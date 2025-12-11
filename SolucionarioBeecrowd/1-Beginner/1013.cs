using System;
using System.Globalization;

class TheGreatest
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine e dividimos em um array de strings

        string[] Values = Console.ReadLine().Split(' ');

        //Convertendo os valores de string para int

        int A = int.Parse(Values[0]);

        int B = int.Parse(Values[1]);

        int C = int.Parse(Values[2]);

        //Agora temos duas formas de fazer essa questão, usando a fórmula dada, ou utilizando um conjunto de ifs para comparar os valores.

        //Esse é o primeiro método, utilizando a fórmula:
        if (A - B > 0)
        {
            if (A - C > 0)
            {
                Console.WriteLine($"{A} eh o maior");
            }
            else
            {
                Console.WriteLine($"{C} eh o maior");
            }
        }
        else
        {
            if (B - C > 0)
            {
                Console.WriteLine($"{B} eh o maior");
            }
            else
            {
                Console.WriteLine($"{C} eh o maior");
            }
        }

        //Esse é o segundo método, utilizando a fórmula dada no enunciado:

        int greatestAB = (A + B + Math.Abs(A - B)) / 2;

        /*Essa fórmula funiona, pois para o módulo de um número, temos duas possibilidades:
        /Se A >= B, então |A - B| = A - B
        Se A < B, então |A - B| = B - A
        Assim, somando A + B + |A - B|, temos:
        Se A >= B: A + B + (A - B) = 2A
        Se A < B: A + B + (B - A) = 2B
        Dividindo o resultado por 2, obtemos o maior valor entre A e B.
        */
        int greatestABC = (greatestAB + C + Math.Abs(greatestAB - C)) / 2;

        Console.WriteLine($"{greatestABC} eh o maior");

        //Ambos os métodos funcionam corretamente, mas o segundo método é mais direto e utiliza a fórmula fornecida no enunciado do problema.


    }
}
