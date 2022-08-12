Console.WriteLine("Введите кооридинты 2-х точек: ");
Console.WriteLine("Введите кооридинту x1: ");
double x1= Convert.ToDouble(Console.ReadLine()) ;
Console.WriteLine("Введите кооридинту y1: ");
double y1= Convert.ToDouble(Console.ReadLine()) ;
Console.WriteLine("Введите кооридинту z1: ");
double z1= Convert.ToDouble(Console.ReadLine()) ;
Console.WriteLine("Введите кооридинту x2: ");
double x2= Convert.ToDouble(Console.ReadLine()) ;
Console.WriteLine("Введите кооридинту y2: ");
double y2= Convert.ToDouble(Console.ReadLine()) ;
Console.WriteLine("Введите кооридинту z2: ");
double z2= Convert.ToDouble(Console.ReadLine()) ;

double Distance (double x1, double y1,double z1,
                 double x2,double y2,double z2)
{
return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
                 };
Console.WriteLine("Длина отрезка равна: ");
Console.WriteLine(Distance (x1,y1,z1,x2,y2,z2));