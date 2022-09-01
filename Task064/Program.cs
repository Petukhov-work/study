
void AllNumber(int m, int n)
{
    Console.Write(m);
    for (int i = m + 1; i <= n; i++)
    {
        Console.Write($", {i}");
    }
}


Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Все числа от M до N: ");
AllNumber(m, n);

