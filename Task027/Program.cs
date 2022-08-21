Console.WriteLine("Введите число: ");
int a= Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine("Сумма всех цифр числа равно: ");
Console.WriteLine(SumFigure(a));
int SumFigure (int x){
    int x1=0;
    while (x!=0) {
        x1=x1+x%10;
        x=x/10;};
    return x1; };



