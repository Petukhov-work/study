Console.WriteLine("Введите 5-ти значное число: ");
int a= Convert.ToInt32(Console.ReadLine()) ;

String Polyd (int x){
int x5=a%10;
int x4=(x/10)%10;
int x2=(x/1000)%10;
int x1=(x/10000)%10;
if (x1==x5 && x2==x4) return "Да";
else {return "Нет";}
}

Console.WriteLine(Polyd(a));
