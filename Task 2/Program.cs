// ввод данных
Console.Write("Введите первое число: ");
float number1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите второе число: ");
float number2 = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите третье число: ");
float number3 = Convert.ToSingle(Console.ReadLine());

// сравниваем числа между собой

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.Write("Максимальное число: ");
        Console.WriteLine(number1); 
    }
    else 
    {
        Console.Write("Максимальное число: ");
        Console.WriteLine(number3);
    }
}
else
{
    if (number2 > number3)
    {
        Console.Write("Максимальное число: ");
        Console.WriteLine(number2); 
    }
    else 
    {
        Console.Write("Максимальное число: ");
        Console.WriteLine(number3);
    }
}