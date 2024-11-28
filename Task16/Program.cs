// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Пример: [3 7 22 2 78] -> 76

int[] GetArrey() // заполняем массив
{
    Random rnd = new Random();
    int[] newArray = new int [4];
    for (int i = 0; i < 4; i++)
    {
        newArray[i] = rnd.Next(-100, 101);
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

int Diff(int[] arr)
{
    int count = 0,
        max = arr[0],
        min = arr[0];
        while (count < 4)
        {
            if(max < arr[count])
            {
                max = arr[count];
            }
            else if (min > arr[count])
            {
                min = arr[count];
            }
            count ++;
        }
        return max - min;
}


int [] arr = GetArrey();
PrintArray(arr);
Console.WriteLine($"разность между максимальным и минимальным элементами равна {Diff(arr)}.");