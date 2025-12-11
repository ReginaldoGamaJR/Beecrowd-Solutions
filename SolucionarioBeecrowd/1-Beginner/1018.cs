using System;
using System.Globalization;

class BankNotes
{
    static void Main(string[] args)
    {
        // Configuração cultural para garantir o formato correto de números
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        // Leitura do valor inicial
        int valor = int.Parse(Console.ReadLine());

        // Saída do valor inicial
        Console.WriteLine(valor);

        // Cálculo do número de notas de cada valor e depois vai retirando usando a %, essa é uma forma mais Bruta e simples de fazer, mas também temos outra com Arrays e Laços 

        int nota100 = valor / 100;
        valor %= 100;

        int nota50 = valor / 50;
        valor %= 50;

        int nota20 = valor / 20;
        valor %= 20;

        int nota10 = valor / 10;
        valor %= 10;

        int nota5 = valor / 5;
        valor %= 5;

        int nota2 = valor / 2;
        valor %= 2;

        int nota1 = valor;

        // Saída formatada
        Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
        Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
        Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
        Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
        Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
        Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
        Console.WriteLine($"{nota1} nota(s) de R$ 1,00");

        //A nossa outra forma será essa abaixo, utilizando Arrays e Laços:

        //Ela certamente é menor e mais elegante, e fica mais fácil de manter caso precisemos adicionar mais notas no futuro.
        //Segue um princípio básico de programação que é o de evitar repetição de código desnecessária.

        int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

        // "Para cada 'nota' dentro da lista 'notas'..."
        foreach (int nota in notas)
        {
            // Calcula quantas notas cabem
            int quantidade = valor / nota;

            // Atualiza o valor com o resto que sobrou
            valor %= nota;

            // Imprime formatado
            Console.WriteLine($"{quantidade} nota(s) de R$ {nota},00");
        }
    }
}