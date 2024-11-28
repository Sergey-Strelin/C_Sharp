// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.*
// Например, задан массив:
// 1 4 7 2  
// 5 9 2 3  
// 8 4 2 4  
// необходимо показать 17 (7 в 1 строке) элемент массива -> такого числа в массиве нет

// создаём массив m*n и заполняем числами от -100 до +100
int[,] GetArray(int m, int n)
{
    int[,] newArray = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i,j] = new Random().Next(-100,101);
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


// ввод размера массива
Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columbs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какой элемент показать?");
Console.Write("введите номер строки: ");
int elementLine = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер столбца: ");
int elementColumn = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columbs);
ViewArray(array);
if (elementLine <= array.GetLength(0) && elementColumn <= array.GetLength(1))
{
    Console.WriteLine($"В {elementLine} строке {elementColumn} элемент имеет значение {array[elementLine-1,elementColumn-1]}. ");
}
else {Console.WriteLine("Такого элемента в массиве нет!");}