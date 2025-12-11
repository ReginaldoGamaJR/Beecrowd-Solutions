using System;
using System.Globalization;

class Area
{
    static void Main(string[] args)
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine e dividimos em um array de strings

        string[] Values = Console.ReadLine().Split(' ');

        //Convertendo os valores de string para double

        double A = double.Parse(Values[0]);

        double B = double.Parse(Values[1]);

        double C = double.Parse(Values[2]);

        //Agora calculamos as áreas conforme as fórmulas que sabemos

        //Área do triângulo retângulo = (base * altura) / 2
        double RectangledTriangle = A * C * 0.5;

        //Área do círculo = π * raio²
        double Circle = 3.14159 * C * C;

        //Área do trapézio = ((base maior + base menor) / 2) * altura
        double Trapezium = (A + B) * 0.5 * C;

        //Área do quadrado = lado * lado
        double Square = B * B;

        //Área do retângulo = base * altura
        double Rectangle = A * B;

        //Exibimos os resultados formatados com três casas decimais
        Console.WriteLine($"TRIANGULO: {RectangledTriangle:F3}");

        Console.WriteLine($"CIRCULO: {Circle:F3}");

        Console.WriteLine($"TRAPEZIO: {Trapezium:F3}");

        Console.WriteLine($"QUADRADO: {Square:F3}");

        Console.WriteLine($"RETANGULO: {Rectangle:F3}");


    }

}