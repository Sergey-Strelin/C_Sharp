// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// Например:
// N = 5 -> "5, 4, 3, 2, 1"  
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  


void GetNambers(int n)
{
    if (n <= 0)
    {
        return;
    }
    if (n!=1) // убираем запятую после 1
    {
        Console.Write($"{n}, ");
    }
    else 
    {
        Console.Write("1");
    }
    GetNambers(n-1);

}

// задаём размер массива
Console.Write("Введите натуральное число больше 1 : ");
int number = Convert.ToInt32(Console.ReadLine());
GetNambers(number);