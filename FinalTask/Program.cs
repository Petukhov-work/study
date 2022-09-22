str [] MassivStr (int length)
{
    str [] array = new str [length];
    for (int i=0; i<array.Length;i=i+1)
    {
        Console.WriteLine("Введите слово в массив");
        array[i]=Console.ReadLine();
    } 
    return array;
}

void PrintMassiv (str [] massiv)
{
    for (int i=0; i< massiv.Length;i++) Console.Write($"{massiv[i]} ");
}