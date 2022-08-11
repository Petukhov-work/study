Console.WriteLine("Введите число: ");
int a= Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine("Все четный числа от 1 до вашего числа: ");

for (int i=1;i <=a; i=i+1) 
 {if (i%2==0)
  {Console.Write(i.ToString()+" ");};}
 


