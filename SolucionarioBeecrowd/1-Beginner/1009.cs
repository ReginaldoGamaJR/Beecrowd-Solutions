using System;
using System.Globalization;

class SalaryWithBonus
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine e convertemos para os tipos apropriados

        string sellerName = Console.ReadLine();

        double fixedSalary = double.Parse(Console.ReadLine());

        double totalSales = double.Parse(Console.ReadLine());

        //Calculamos o salário final incluindo a comissão de 15% sobre as vendas totais

        double commission = totalSales * 0.15;

        //Calculamos o salário final somando o salário fixo e a comissão

        double finalSalary = fixedSalary + commission;

        //Obs: Poderíamos também ter feito tudo em uma única linha, porém , para melhor clareza, optamos por separar os cálculos em etapas distintas.

        //Ficaria assim: double finalSalary = fixedSalary + (totalSales * 0.15);

        //Exibimos o resultado formatado com duas casas decimais

        Console.WriteLine($"TOTAL = R$ {finalSalary:F2}");

    }
}