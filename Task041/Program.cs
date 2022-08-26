
int [] FillingArray (int length)
{
    int [] array=new int [length];

    for (int i=0; i<length; i++)
    {
       Console.WriteLine("Введите число в массив : ");
       array[i] = Convert.ToInt32(Console.ReadLine()) ;
    }
    return array;
}



int PositiveNumber (int [] array)
{
    int count=0;
    for (int i=0; i<array.Length;i=i+1)
    {
        if (array[i]>0 ) count++;
    }
    return count;
}


Console.WriteLine("Введите количество чисел в массиве : ");
int lengthArray= Convert.ToInt32(Console.ReadLine()) ;

int [] array=FillingArray(lengthArray);


Console.WriteLine("Количество положительных элементов в массиве: ");
Console.Write(PositiveNumber(array));