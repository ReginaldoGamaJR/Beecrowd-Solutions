using System;
using System.Globalization;

class SimpleCalculate
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine e convertemos para os tipos apropriados

        //Agora a leitura terá que ser feita em duas linhas diferentes, uma para cada produto.

        //Primeira linha de entrada, agora contém 3 elementos : código do produto 1, número de unidades e valor por unidade.

        //Vamos criar uma lista de strings para armazenar esses valores temporariamente.

        //E vamos dividir a string lida em partes utilizando o método Split, que separa a string com base no caractere que eu escolher, no caso o espaço em branco. ' '

        string[] item1 = Console.ReadLine().Split(' ');

        int code1 = int.Parse(item1[0]);

        int numberOfUnits1 = int.Parse(item1[1]);

        double valuePerUnit1 = double.Parse(item1[2]);

        //Segunda linha de entrada, agora contém 3 elementos : código do produto 2, número de unidades e valor por unidade.

        string[] item2 = Console.ReadLine().Split(' ');

        int code2 = int.Parse(item2[0]);

        int numberOfUnits2 = int.Parse(item2[1]);

        double valuePerUnit2 = double.Parse(item2[2]);

        //Calculamos o valor total a ser pago somando o valor total de cada produto

        double totalToPay = (numberOfUnits1 * valuePerUnit1) + (numberOfUnits2 * valuePerUnit2);

        //Exibimos o resultado formatado com duas casas decimais

        Console.WriteLine($"VALOR A PAGAR: R$ {totalToPay:F2}");

        //Para formartarmos as casas decimais também poderíamos utilizar o método ToString("F2") no totalToPay;
    }
}