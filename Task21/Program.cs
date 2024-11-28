// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*
// Например, задан массив:  
// 1 4 7 2  
// 5 9 2 3  
// 8 4 2 4  
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// создаём массив m*n и заполняем положительными целыми числами от 0 до +99
int[,] GetArray(int m, int n)
{
    int[,] newArray = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i,j] = new Random().Next(0,100);
        } 
    }
    return newArray;
}


// выводим полученный массив на экран
void ViewArray (int[,] array)
{
    Console.WriteLine($"В массиве :");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        } 
        Console.WriteLine();
    }

}

//считаем среднее значение чисел в каждом столбце
void AvirageValueColumbs(int[,] array)
{
    Console.WriteLine("Среднее значение:");
    double[] averageValue = new double[array.GetLength(1)]; // создаём массив для средних значений
    for (int i = 0; i < array.GetLength(1); i++)            // пробегаемся по столбцам
    {
        averageValue[i] = 0;
        for (int j = 0; j < array.GetLength(0); j++)        // для каждого столбца считаем среднее
        {
            averageValue[i] += array[j,i];
        }
        Console.WriteLine($"в столбце {i+1} равно {Math.Round(averageValue[i]/array.GetLength(0),2)}");
    }
}

// задаём размер массива
Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columbs = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columbs); // создаём и заполняем массив
ViewArray(array);                       // выводим массив на экран
AvirageValueColumbs(array);             // находим среднее по каждому столбцу и выводим на экран