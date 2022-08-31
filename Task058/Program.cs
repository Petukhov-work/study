

int [,] CreateMatrix (int rowCount, int columnCount)
{
    int [,] array = new int [rowCount,columnCount];
    for (int row=0; row<rowCount;row++) 
    {
        for (int column=0; column<columnCount;column++)
        {
            array[row,column]= new Random().Next(0,10);
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

int [,] MultiplyMatrix (int [,] array1,int [,] array2)
{   
    int [,] array= new int [array1.GetLength(0),array1.GetLength(1)];
    for (int row=0; row<array1.GetLength(0);row++) 
    {
        for (int column=0; column<array1.GetLength(1);column++)
        {
            array[row,column]=MultiplyMatrixElement(array1,array2,row,column);
        }
    }
    return array;
}

int  MultiplyMatrixElement (int [,] array1,int [,] array2, int row, int column)
{   
    int element=0;
    for (int i=0; i<array1.GetLength(0);i++) 
    {
        element=element+array1[row,i]*array2[i,column];
    }
    return element;
}

Console.WriteLine("Введите размер матрицы");

Console.WriteLine("Количество строк:");
int row= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Количество столбцов:");
int column= Convert.ToInt32(Console.ReadLine()) ;

int  [,] array1=CreateMatrix(row, column);

Console.WriteLine();

PrintMatrix(array1);

int  [,] array2=CreateMatrix(row, column);

Console.WriteLine();

PrintMatrix(array2);

Console.WriteLine("Перемноженная матрица");

Console.WriteLine();

PrintMatrix(MultiplyMatrix(array1,array2));
