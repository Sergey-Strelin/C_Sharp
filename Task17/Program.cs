// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// конечно можно было проверять больше нуля или нет при вводе чисел, да и массив не особо нужен... 
// зато попрактиковался в массивах и функциях

// спаршиваем сколько чисел будет вводиться (по условию М... то есть сколько захочет)
// создаём массив на введённое количество элементов, заполняем и считаем

int[] InputNum(int numOfNum)
{
    int[] arr = new int [numOfNum];
    for(int i = 0; i < numOfNum; i++ )
    {
        Console.Write($"Введите {i+1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int GreaterThanZero(int[] array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

Console.Write("Введите количство чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введено числе - {num}, из них {GreaterThanZero(InputNum(num))} больше нуля");