// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// метод подсчёта суммы чисел в введённом числе
int SummaNum(string num)
{
    int count = 0,
        sum = 0;
    while (count < num.Length)
    {
        sum = sum + Int32.Parse(num[count].ToString());
        count ++;
    }
    return sum;
}

// ввод данных
Console.Write("Введите натуральное число: ");
string number = Console.ReadLine();

// вывод суммы чисел в числе и вызов метода
Console.WriteLine($"Сумма чисел в числе {number} равна {SummaNum(number)}");