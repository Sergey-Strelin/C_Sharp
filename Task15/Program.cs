// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Примеры: [3, 7, 23, 12] -> 19
//          [-4, -6, 89, 6] -> 0

int[] GetArrey() // заполняем массив
{
    Random rnd = new Random();
    int[] newArray = new int [4];
    for (int i = 0; i < 4; i++)
    {
        newArray[i] = rnd.Next(-1000, 1001);
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

int Sum(int[] arr)
{
    int count = 0;
    int summa = 0;
    while (count < 4)
    {
        if (count % 2 == 1)
        {
            summa = summa + arr[count];
        }
        count ++;
    }
    return summa;
}
int [] arr = GetArrey();
PrintArray(arr);
Console.WriteLine($"сумма элементов на не чётных позициях равна {Sum(arr)}.");