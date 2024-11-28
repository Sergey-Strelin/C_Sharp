// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:  
// 1 4 7 2  
// 5 9 2 3  
// 8 4 2 4  
// 5 2 6 7  
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка 


// создаём массив m*n и заполняем положительными целыми числами от 0 до +10
int[,] GetArray(int m, int n)
{
    int[,] newArray = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i,j] = new Random().Next(0,11);
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

// считаем сумму в каждой строке и складываем в массив
int[] GetRowsSumma(int[,] array)
{
    int[] summaRows = new int[array.GetLength(0)];
    for (int i=0; i < array.GetLength(0); i++)
    {
        summaRows[i] = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            summaRows[i] += array[i,j];
        }
//        Console.WriteLine($" summa{i} = {summaRows[i]}");  // контроль подсчитанной сыммы в строке
    }
    return summaRows;
}

//ищем минимальное значение суммы
void FindMinimum(int[] arraySumma) 
{
    int minimum = arraySumma[0];
    int indexMinimum = 1;
    for (int i = 0; i < arraySumma.Length; i++)
    {
        if (minimum > arraySumma[i]) 
        {
            minimum = arraySumma[i];
            indexMinimum = i+1;
        }
    }
    Console.WriteLine($"строка с наименьшей суммой элементов: {indexMinimum} (сумма элементов в строке равна {minimum} )");
}



// задаём размер массива строки = столбцам
Console.Write("Введите размер массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columbs = rows;

int[,] array = GetArray(rows, columbs); // создаём и заполняем массив
ViewArray(array);                       // выводим массив на экран
FindMinimum(GetRowsSumma(array));                    // считаем сумму членов в каждой строке и ищем минимальное значение