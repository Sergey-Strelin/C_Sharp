// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//

void GetRatio(float k1, float b1, float k2, float b2)
{
    if (k1 == k2)
    {   
        Console.WriteLine("Эти прямые параллельные и точек пересечения не имеют!");
    }
    else
    {
        float x = (b2 - b1) / (k1 - k2);
        float y = k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения прямых х = {x}, y = {y}");
    }
}

Console.Write("k1 = ");
float k1 = Convert.ToSingle(Console.ReadLine());
Console.Write("b1 = ");
float b1 = Convert.ToSingle(Console.ReadLine());
Console.Write("k2 = ");
float k2 = Convert.ToSingle(Console.ReadLine());
Console.Write("b1 = ");
float b2 = Convert.ToSingle(Console.ReadLine());

//вызываем метод определения координаты точки пересечения
GetRatio(k1, b1, k2, b2);