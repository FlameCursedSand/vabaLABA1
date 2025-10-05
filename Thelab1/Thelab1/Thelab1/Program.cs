using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b;
        Console.WriteLine("Введите 1 сторону прямоугольника:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите 2 сторону прямоугольника:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Площадь = {a*b}, Периметр = {2 * (a+b)}, Диагональ = {Math.Sqrt(a*a + b*b)}.");
    }
}