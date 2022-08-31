

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

int  Sum (int [,] array,int row)
{   
        int sumColumn=array[row,0];
        for (int column=1; column<array.GetLength(1);column++)
        {
            sumColumn=sumColumn+array[row,column];
        };   
        
    
    return sumColumn;
}

int  MinSumColumn (int [,] array)
{   
    int min=Sum(array,0);
    int count=0;
    for (int row=1; row<array.GetLength(0);row++) 
    {
        int sum1=Sum(array,row);   
        if (sum1<min)
        {
           min=sum1;
           count=row;
        } ;
    }
    return count;
}

Console.WriteLine("Введите размер матрицы");

Console.WriteLine("Количество строк:");
int row= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Количество столбцов:");
int column= Convert.ToInt32(Console.ReadLine()) ;

int  [,] array=CreateMatrix(row, column);

Console.WriteLine();

PrintMatrix(array);

Console.WriteLine($"Номер строки с минимальной суммой:{MinSumColumn (array)+1}");

