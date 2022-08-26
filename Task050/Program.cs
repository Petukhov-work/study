

int [,] CreateMatrix (int rowCount, int columnCount)
{
    int [,] array = new int [rowCount,columnCount];
    for (int row=0; row<rowCount;row++) 
    {
        for (int column=0; column<columnCount;column++)
        {
            array[row,column]= new Random().Next(-100,100);
        }
    }
    
    return array;
}

void PrintMatrix (int [,] array)
{
    for (int row=0; row<array.GetLength(0);row++) 
    {
        for (int column=0; column<array.GetLength(1);column++)
        {
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер матрицы");

Console.WriteLine("Количество строк:");
int row= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Количество столбцов:");
int column= Convert.ToInt32(Console.ReadLine()) ;

int  [,] array=CreateMatrix(row, column);

PrintMatrix(array);

Console.WriteLine("Введите номер строк необходимого элемента:");
int rowX= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Введите номер столбца необходимого элемента:");
int columnX= Convert.ToInt32(Console.ReadLine()) ;

if (rowX<=row && columnX<=column )
{
    Console.WriteLine(array[rowX-1,columnX-1]);
}
 
else
{
    Console.WriteLine("Такого элекмента нет");
}
