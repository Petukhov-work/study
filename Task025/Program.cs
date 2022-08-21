Console.WriteLine("Введите первое число : ");
int x1= Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine("Введите второе число : ");
int x2= Convert.ToInt32(Console.ReadLine()) ;
int Power (int y1,int y2)
{
    int res=1;
    for (int i=1; i<=y2;i=i+1)
    {
        res=res*y1;
        }
    return res;
}
Console.WriteLine("Первое число в стпени второго равно: ");
Console.Write(Power(x1,x2));

