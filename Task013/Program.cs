Console.WriteLine("Введите число: ");
int a= Convert.ToInt32(Console.ReadLine()) ;

int b=(a/10/10)%10;
if (b>0) Console.WriteLine(b);
else {Console.WriteLine("третьей цифры нет");}
