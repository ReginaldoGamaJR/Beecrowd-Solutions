using System;
using System.Globalization;

class DistanceBetweenTwoPoints
{
    static void Main(string[] args)
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine e dividimos em um array de strings

        string[] Point1 = Console.ReadLine().Split(' ');

        double X1 = double.Parse(Point1[0]);

        double Y1 = double.Parse(Point1[1]);

        //Lemos os valores do segundo ponto

        string[] Point2 = Console.ReadLine().Split(' ');

        double X2 = double.Parse(Point2[0]);

        double Y2 = double.Parse(Point2[1]);

        //Calculamos a distância entre os dois pontos utilizando a fórmula da distância euclidiana

        //Distância = √((X2 - X1)² + (Y2 - Y1)²)

        //Vou utilizar a classe Math para calcular a raiz quadrada e a potência

        double Distance = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));

        //Exibimos o resultado formatado com quatro casas decimais
        Console.WriteLine(Distance.ToString("F4"));
    }

}