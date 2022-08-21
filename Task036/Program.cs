

int [] Massiv8 ()
{
    int [] array = new int [8];
    for (int i=0; i<array.Length;i=i+1) array[i]= new Random().Next(-100,100);
    return array;
}

void PrintMassiv (int [] massiv)
{
    for (int i=0; i< massiv.Length;i++) Console.Write($"{massiv[i]} ");
}



int SumNotEven (int [] massiv)
{   
    int sum=0;
    for (int i=0; i< massiv.Length;i++) 
    {
        if (i%2==1) sum=sum+massiv[i];
    }
    return sum;
}

int [] res=Massiv8();
Console.WriteLine("Массив из случайных цифр : ");
PrintMassiv(res);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях : {SumNotEven(res)}");
