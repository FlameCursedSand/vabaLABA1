using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, S, P, d, res1, res2;
        Console.WriteLine("Введите 1 сторону прямоугольника:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите 2 сторону прямоугольника:");
        b = Convert.ToDouble(Console.ReadLine());
        S = a * b;
        P = 2 * (a + b);
        d = Math.Sqrt(a*a + b*b);
        Console.WriteLine($"Площадь = {S}, Периметр = {P}, Диагональ = {d}.");
    }
}