

int [,] CreateMatrix (int rowCount, int columnCount)
{
    int [,] array = new int [rowCount,columnCount];
    for (int row=0; row<rowCount;row++) 
    {
        for (int column=0; column<columnCount;column++)
        {
            array[row,column]= new Random().Next(0,100);
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

int [,] SortMaxElementMatrix (int [,] array)
{
    for (int row=0; row<array.GetLength(0);row++) 
    {
        
        for (int column=0; column<(array.GetLength(1)-1);column++)
        {
            int max=array[row,column];
            int count=column;
            for (int column1=column+1; column1<array.GetLength(1);column1++)
            {
                if (array[row,column1]>max) 
                {
                    max=array[row,column1];
                    count=column1;
                }
            }
            array[row,count]=array[row,column];
            array[row,column]=max;

        }
        
    }
    return array;
}

Console.WriteLine("Введите размер матрицы");

Console.WriteLine("Количество строк:");
int row= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Количество столбцов:");
int column= Convert.ToInt32(Console.ReadLine()) ;

int  [,] array=CreateMatrix(row, column);

Console.WriteLine();

PrintMatrix(array);

Console.WriteLine();

PrintMatrix(SortMaxElementMatrix(array));