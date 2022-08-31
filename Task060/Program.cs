

int [,,] CreateMatrix3D(int rowCount, int columnCount, int hCount)
{   int [,,] array = new int [rowCount,columnCount,hCount];
    for (int h=0; h<hCount;h++)
    {
        for (int row=0; row<rowCount;row++) 
        {
            for (int column=0; column<columnCount;column++)
            {
                array[row,column,h]= new Random().Next(0,99);
            }
        }
    }
    
    
    return array;
}

void PrintMatrix3D (int [,,] array)
{
    for (int row=0; row<array.GetLength(0);row++) 
    {
        for (int column=0; column<array.GetLength(1);column++)
        {
            for (int h=0; h<array.GetLength(2);h++)
            {
                Console.WriteLine($"{array[row, column,h]} ({row},{column},{h}) ");
            }    
        }
        
    }
}



Console.WriteLine("Введите размер матрицы");

Console.WriteLine("Количество строк:");
int row= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Количество столбцов:");
int column= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Глубину 3d матрицы:");
int h= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine();
PrintMatrix3D(CreateMatrix3D(row, column,h));

