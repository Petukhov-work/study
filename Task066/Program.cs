
int SumNumber(int m, int n)
{
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum = sum + i;
    }
    return sum;
}


Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма всех чисел от M до N: {SumNumber(m, n)}");


