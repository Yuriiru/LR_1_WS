using System;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите колличество шагов n: ");

        int n = Convert.ToInt32(Console.ReadLine());
        while (n < 0)
        {
            Console.Write("Вы ввели отрицательное число шагов, введите заново n: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Введите значение х: ");

        int x = Convert.ToInt32(Console.ReadLine());
        int s = 0;
        for (int i = 0; i < n + 1; i++)
        {
            int p = (GetPow(-1, n) * GetPow(x - 1, n + 1) / (n + 1));
            s += p;
        }
        Console.WriteLine(s);

        static int GetPow(int number, int pow)
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
                result *= number;
            return result;
        }

        Console.ReadLine();
    }
}