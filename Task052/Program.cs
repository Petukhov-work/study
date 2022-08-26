

double [,] CreateMatrix (int rowCount, int columnCount)
{
    double [,] array = new double [rowCount,columnCount];
    for (int row=0; row<rowCount;row++) 
    {
        for (int column=0; column<columnCount;column++)
        {
            array[row,column]= new Random().Next(-100,100);
        }
    }
    
    return array;
}

void PrintMatrix (double [,] array)
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

void AverageNumberRow (double [,] array)
{
    for ( int column=0; column<array.GetLength(1);column++) 
    {
        double SumRow=0;
        for (int row=0; row<array.GetLength(0);row++)
        {
            SumRow=SumRow+array[row, column];
        }
        Console.Write($"{SumRow/array.GetLength(0)} ");
    }
}


Console.WriteLine("Введите размер матрицы");

Console.WriteLine("Количество строк:");
int row= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Количество столбцов:");
int column= Convert.ToInt32(Console.ReadLine()) ;

double  [,] array=CreateMatrix(row, column);

PrintMatrix(array);

Console.WriteLine("Среднее арифметическое столбцов:");
AverageNumberRow(array);

