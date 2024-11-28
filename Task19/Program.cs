// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Например: 
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// создаём массив m*n и заполняем числами от -50 до +50
double[,] GetArray(int m, int n)
{
    double[,] newArray = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i,j] = Math.Round(new Random().NextDouble()*100 - 50, 2);
        } 
    }
    return newArray;
}


// выводим полученный массив на экран
void ViewArray (double[,] array)
{
    Console.WriteLine($"Массив {array.GetLength(0)} х {array.GetLength(1)} :");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        } 
        Console.WriteLine();
    }

}

// ввод размера массива
Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columbs = Convert.ToInt32(Console.ReadLine());

double[,] array = GetArray(rows, columbs);
ViewArray(array);