// ввод данных
Console.Write("Введите натуральное число от 1 до 10 000: ");
int number = Convert.ToInt16(Console.ReadLine());

//готовим вывод данных
Console.Write("В интервале от 1 до ");
Console.Write(number);

//проверяем, что ввели не 1
if (number == 1)
{
    Console.WriteLine(" чётных чисел нет");
}
else
{
    Console.WriteLine(" включительно, имеются следующие чётные числа:");
    int num = 2;
    while(num <= number)
    {
        Console.Write(num);
        Console.Write(" ");
        num = num + 2;
    }
}