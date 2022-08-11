Console.WriteLine("Введите 3 числа: ");
int a= Convert.ToInt32(Console.ReadLine()) ;
int b= Convert.ToInt32(Console.ReadLine()) ;
int c= Convert.ToInt32(Console.ReadLine()) ;
int max;
if (a>b) 
 max=a;
else max= b;
if (c>max)
 max= c;
Console.Write("Максимальное из трех чисел равен: ");
Console.WriteLine(max);