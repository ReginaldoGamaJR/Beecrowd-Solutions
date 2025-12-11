using System;
using System.Globalization;

class BankNotesAndCoins
{
    static void Main(string[] args)
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Estabelecemos os valores das notas e moedas em arrays para facilitar a iteração

        double[] notes = { 100.00, 50.00, 20.00, 10.00, 5.00, 2.00 };

        double[] coins = { 1.00, 0.50, 0.25, 0.10, 0.05, 0.01 };

        //Lemos o valor monetário de entrada, adicionando uma pequena margem para evitar problemas de precisão com ponto flutuante

        double money = double.Parse(Console.ReadLine()) + 0.0001;

        //Calculamos a quantidade de cada nota e moeda necessária
        Console.WriteLine("NOTAS:");
        foreach (double note in notes)
        {
            int amount = (int)(money / note);

            money %= note;

            Console.WriteLine($"{amount} nota(s) de R$ {note:F2}");
        }
        //Agora fazemos o mesmo para as moedas
        Console.WriteLine("MOEDAS:");

        foreach (double coin in coins)
        {
            int amount = (int)(money / coin);

            money %= coin;

            Console.WriteLine($"{amount} moeda(s) de R$ {coin:F2}");
        }

        //Dessa forma funciona, porém vale lembrar que operações com ponto flutuante podem introduzir pequenas imprecisões.

        //Agora vamos fazer uma abordagem alternativa utilizando inteiros para evitar problemas de precisão.

        /*
         * Mexer com Float ou Double pode causar problemas de precisão em algumas situações,
         * pois um computador não é capaz de guardar 0.1 exatamente,
         * ele guarda uma aproximação disso. Então, quando fazemos várias operações matemáticas com esses números,
         * os erros de aproximação podem se acumular e resultar em valores inesperados.
         * 
         * ~Então, é mais seguro trabalhar com inteiros quando possível, especialmente em casos como este,
         * Vamos multiplicar por 100, para passar tudo para centavos, e vamos somar 0.5 antes de converter para inteiro, para garantir o arredondamento correto.
         * Arredondaremos casos como 0.0999999 para 0.10 corretamente.
         * E depois basta seguir a mesma ideia, porém agora tudo em centavos.
         */

        int[] notesInt = { 10000, 5000, 2000, 1000, 500, 200 };

        int[] coinsInt = { 100, 50, 25, 10, 5, 1 };

        double money2 = double.Parse(Console.ReadLine());

        int totalCoins = (int)(money * 100 + 0.5);

        Console.WriteLine("NOTAS:");
        foreach (int note in notes)
        {
            int amount = totalCoins / note;

            totalCoins %= note;

            Console.WriteLine($"{amount} nota(s) de R$ {note / 100.0:F2}");
        }
        Console.WriteLine("MOEDAS:");
        foreach (int coin in coins)
        {
            int amount = (int)(totalCoins / coin);

            totalCoins %= coin;

            Console.WriteLine($"{amount} moeda(s) de R$ {coin / 100.0:F2}");
        }

        //Ambas as abordagens são válidas, mas a segunda evita problemas de precisão associados a operações com ponto flutuante.
        //E ambas tem complexidade O(1), já que o número de notas e moedas é fixo e não depende da entrada.

    }

}