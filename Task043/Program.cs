
int IntersectionPointX (int k1, int b1, int k2, int b2) 
{
    return  (b2-b1)/(k1-k2);
}

Console.WriteLine("Введите значения k1: ");
int k1= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Введите значения b1: ");
int b1= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Введите значения k2: ");
int k2= Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Введите значения b2: ");
int b2= Convert.ToInt32(Console.ReadLine()) ;


int pointX=IntersectionPointX(k1,b1,k2,b2);
int pointY=k1*pointX+b1;

Console.WriteLine($"Точка перечений прямых: x={pointX}, y={pointY}");
