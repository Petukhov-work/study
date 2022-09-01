
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }

    return Akkerman(m - 1, Akkerman(m, n - 1));
}


Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для M и N: {Akkerman(m, n)}");


