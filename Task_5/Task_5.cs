﻿class Loops
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}