using System;

class CalculateXY
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Введіть число A: ");

        double a = Convert.ToDouble(Console.ReadLine());

        double x;
        if (a <= 0 || a > 13)
        {
            x = 9 * a - 8.9;
        }
        else if (0 < a && a < 5)
        {
            x = Math.Pow(-9 * a + 4, 4);
        }
        else
        {
            x = (4 + 1.6) * (7.2 / 3.8);
        }

        double y = Math.Sqrt(a) - 8;

        Console.WriteLine($"Значення X: {x}");
        Console.WriteLine($"Значення Y: {y}");

        Console.ReadKey();
    }
}
