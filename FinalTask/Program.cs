string [] MassivStr (int length)
{
    string [] array = new string [length];
    for (int i=0; i<array.Length;i=i+1)
    {
        Console.WriteLine("Введите слово в массив");
        array[i]=Console.ReadLine();
    } 
    return array;
}

void PrintMassiv (string [] massiv)
{
    for (int i=0; i< massiv.Length;i++) Console.Write($"{massiv[i]} ");
}

string [] FindStr (string [] massiv, int lengthStr)
{
    string [] array =  new string [massiv.Length];
    int b=0;
    for (int i=0; i<massiv.Length;i=i+1)
    {
        if (massiv[i].Length<=lengthStr) 
        {
            array[b]=massiv[i];
            b=b+1;
        }
    }
    return array;
}

Console.WriteLine("Введите количетво слов в массиве");
int numberWord=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетво букв в слове, которые надо вывести");
int numberStr=Convert.ToInt32(Console.ReadLine());
string [] array= MassivStr(numberWord);
Console.WriteLine($"Слова с количеством букв равным или меньшим, чем {numberStr}");
PrintMassiv(FindStr(array,numberStr));

