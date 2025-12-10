using System;

class ExtremelyBasic
{
    static void Main(string[] args)
    {
        //Para problemas mais complexos usaremos o StreamReader, todavia para problemas mais simples não é necessário.
        //Lemos os valores de entrada utilizando o Console.ReadLine e convertemos para inteiro
        int N1 = int.Parse(Console.ReadLine());

        int N2 = int.Parse(Console.ReadLine());

        int X = N1 + N2;
        //Nós podemos agora de duas formas imprimir o resultado:
        Console.WriteLine($"X = {X}");

        //Ou também:

        Console.WriteLine("X = " + X);
    }

}
