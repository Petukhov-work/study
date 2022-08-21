

int [] Massiv8 ()
{
    int [] array = new int [8];
    for (int i=0; i<array.Length;i=i+1) array[i]= new Random().Next(100,999);
    return array;
}

void PrintMassiv (int [] massiv)
{
    for (int i=0; i< massiv.Length;i++) Console.Write($"{massiv[i]} ");
}



int Even (int [] massiv)
{   
    int count=0;
    for (int i=0; i< massiv.Length;i++) 
    {
        if (massiv[i]%2==0) count++;
    }
    return count;
}

int [] res=Massiv8();
Console.WriteLine("Массив из случайных трехзначных цифр : ");
PrintMassiv(res);
Console.WriteLine($"Количество четных цифр в нем : {Even(res)}");
