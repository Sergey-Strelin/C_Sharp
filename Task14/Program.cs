// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// Пример: [345, 897, 568, 234] -> 2

int[] GetArrey() // заполняем массив
{
    Random rnd = new Random();
    int[] newArray = new int [4];
    for (int i = 0; i < 4; i++)
    {
        newArray[i] = rnd.Next(100, 1001);
    }
    return newArray;
}

void PrintArray(int[] arr) // выводим массив на экран
{
    Console.Write("В массиве: [");
    for (int i = 0; i < 4; i++)
    {
        Console.Write(arr[i]);
        if (i < 3) Console.Write(", "); // после каждого (кроме последнего) члена массива выводим запятую
    }
    Console.Write("] "); //закрываем квадратную скобку после последнего члена массива
}

int CountingEvenNumbers(int[] arr)
{
    int count = 0;
    int quantity = 0;
    while (count < 4)
    {
        if (arr[count] % 2 == 0)
        {
            quantity ++;
        }
        count ++;
    }
    return quantity;
}
int [] arr = GetArrey();
PrintArray(arr);
Console.WriteLine($"содержится {CountingEvenNumbers(arr)} чётных чисел");