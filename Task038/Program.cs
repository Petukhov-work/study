

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



int Max (int [] massiv)
{   
    int max=massiv[0];
    for (int i=1; i< massiv.Length;i++) 
    {
        if (max<massiv[i]) max=massiv[i];
    }
    return max;
}

int Min (int [] massiv)
{   
    int min=massiv[0];
    for (int i=1; i< massiv.Length;i++) 
    {
        if (min>massiv[i]) min=massiv[i];
    }
    return min;
}

int [] res=Massiv8();
Console.WriteLine("Массив из случайных цифр : ");
PrintMassiv(res);
Console.WriteLine($"Разница между максимальным и минмальным элекметном массива : {Max(res)-Min(res)}");
