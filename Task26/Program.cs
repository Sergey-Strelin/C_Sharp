// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:  
// 01 02 03 04  
// 12 13 14 05  
// 11 16 15 06  
// 10 09 08 07  


int[,] GetSpiralArray(int m, int n)
{
    int[,] newArray = new int[m,n];
    int rowStart = 0,
        rowStop = m-1,
        columbStart = 0,
        columbStop = n-1,
        number = 0,
        i = 0,
        j = 0;
    while (number < m * n)
    {
// заполняем строку i слева на право
        for (j = columbStart; j <= columbStop; j++)
        {
            newArray[i,j] = number;
            number++;
        }    
// заполняем столбец j с верху в низ
        j--;
        rowStart++;
        for (i = rowStart; i <= rowStop; i++)
        {
            newArray[i,j] = number;
            number++;
        }
// заполняем строку i с права на лево
        i--;
        columbStop--;
        for (j = columbStop; j >= columbStart; j--)
        {
            newArray[i,j] = number;
            number++;
        }
// заполняем столбец j с низу в верх
        j++;
        rowStop--;
        for (i = rowStop; i >= rowStart; i--)
        {
            newArray[i,j] = number;
            number++;
        }
        i++;
        columbStart++;
    }
    return newArray;
}

// выводим полученный массив на экран
void ViewArray (int[,] array)
{
    Console.WriteLine("Итоговый массив :");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        } 
        Console.WriteLine();
    }
}



Console.Write("Введите количество строк в матрице: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в мартице: ");
int columbs = Convert.ToInt32(Console.ReadLine());
int[,] array = GetSpiralArray(rows, columbs);  // создаём и заполняем массив
ViewArray(array);               // выводим массив на экран