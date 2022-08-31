
int [,] CreateMatrixSpiral (int rowCount, int columnCount)
{
    int [,] array = new int [rowCount,columnCount];
    
    int column=0;
    int row=0;
    int dColumn=1;
    int dRow=0;

    for (int count=1;count<=rowCount*columnCount; count++)
    {
        array [row,column]=count;
        int iRow=row+dRow;
        int iColumn=column+dColumn;
        if (iRow>=0 &&
            iRow<rowCount &&
            iColumn>=0 &&
            iColumn<columnCount &&
            array[iRow,iColumn]==0)
            {
                row=iRow;
                column=iColumn;
            }
        else 
        {
            int i=dRow;
            dRow=dColumn;
            dColumn=-i;
            row=row+dRow;
            column=column+dColumn;
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

Console.WriteLine();
PrintMatrix(CreateMatrixSpiral(row, column));

