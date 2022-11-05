/*Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите значение b1");
double numFirst = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2");
double numSekond = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k1");
double numThird = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2");
double numFour = double.Parse(Console.ReadLine()!);
{
    if (numFirst == numThird && numSekond == numFour)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (numThird == numFour)
    {
        Console.WriteLine("Прямые параллельные");
    }
    else
    {
        double axisX = (numSekond - numFirst) / (numThird - numFour);
        double axisY = (numThird * axisX) + numFirst;
        Console.WriteLine($"координата Х {axisX}, координата Y {axisY}");
    }
}
