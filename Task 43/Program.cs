// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Даны два уравнения: ");
Console.WriteLine("Уравнение №1: y = k1 * x + b1"); // y=5x+2
Console.WriteLine("Уравнение №2: y = k2 * x + b2"); //y=9x+4

double[] InputValue()
{
    double[] arrayVaiue = new double[4];
    Console.WriteLine("Введите значения b1 и k1 для первого уравнения, а так же b2 и k2 для второго уровнения через ENTER: ");
    for (int i = 0; i < 4; i++)
    {
        arrayVaiue[i] = double.Parse(Console.ReadLine()!);
    }
    return arrayVaiue;
}

void PrinteQuations(double[] arrayVaiue)
{
    Console.WriteLine("По введенным данным получились два уравнения: ");
    Console.WriteLine($"y = {arrayVaiue[1]} * x + {arrayVaiue[0]}");
    Console.WriteLine($"y = {arrayVaiue[3]} * x + {arrayVaiue[2]}");
}

void Decision(double[] arrayVaiue)
{
    double resultX = (-arrayVaiue[0] + arrayVaiue[2]) / (arrayVaiue[1] - arrayVaiue[3]);
    double resultY = (arrayVaiue[3] * resultX) + arrayVaiue[2];
    Console.WriteLine($"Точка пересечения прямых = ({resultX};{resultY})");
}

double[] variables = InputValue();
PrinteQuations(variables);
Decision(variables);

