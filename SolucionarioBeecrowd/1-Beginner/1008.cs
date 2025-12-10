using System;
using System.Globalization;

class Salary
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine e convertemos para os tipos apropriados

        int employeeNumber = int.Parse(Console.ReadLine());

        int hoursWorked = int.Parse(Console.ReadLine());

        double hourlyRate = double.Parse(Console.ReadLine());

        //Calculamos o salário do funcionário

        double salary = hoursWorked * hourlyRate;

        //Imprimimos o resultado no formato solicitado

        Console.WriteLine($"NUMBER = {employeeNumber}");

        Console.WriteLine($"SALARY = U$ {salary:F2}");

    }
}