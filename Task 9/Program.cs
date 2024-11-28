// описываем метод
void GetDistance (double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    // расстояние между точкамм
    Console.Write("Расстояние между точками: ");
    Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(X1-X2,2)+Math.Pow(Y1-Y2,2)+Math.Pow(Z1-Z2,2)),2));
}

// ввод данных
Console.WriteLine("Введите координаты первой точки:");
Console.Write("x1 = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1 = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1 = ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("x2 = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2 = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2 = ");
double z2 = Convert.ToDouble(Console.ReadLine());

// вызываем метод 
GetDistance(x1,y1,z1,x2,y2,z2);