// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*
// Например, задан массив:  
// 1 4 7 2  
// 5 9 2 3  
// 8 4 2 4  
// В итоге получается вот такой массив:  
// 7 4 2 1  
// 9 5 3 2  
// 8 4 4 2  


// создаём массив 4*3 и заполняем положительными целыми числами от 0 до +10
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

// сортируем строки
void SortArray(int[,] array)
{
    int tmp = 0;
    bool sortStop = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sortStop = true;
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i,k] < array[i,k+1])
                {
                    tmp = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = tmp;
                    sortStop = false;
                }
            }
            if (sortStop) break;
        }
    }
    ViewArray(array);
}


Console.Write("Введите количество строк в матрице: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в мартице: ");
int columbs = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columbs);  // создаём и заполняем массив
ViewArray(array);               // выводим массив на экран
SortArray(array);               // сортируем строки