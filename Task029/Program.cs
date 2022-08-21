Console.WriteLine("Массив из 8 цифр : ");

int [] Massiv8 ()
{
    int [] array = new int [8];
    for (int i=0; i<array.Length;i=i+1) array[i]= new Random().Next(0,100);
    return array;
}
void PrintMassiv (int [] massiv)
{
    for (int i=0; i< massiv.Length;i++) Console.Write($"{massiv[i]} ");
}
PrintMassiv(Massiv8());