// ввод данных
Console.Write("Введите первое число: ");
float number1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите второе число: ");
float number2 = Convert.ToSingle(Console.ReadLine());

// определяем какое больше 
if (number1 > number2)
{       
    Console.Write("Максимальное число: ");
    Console.WriteLine(number1);
    Console.Write("Минимальное число: ");
    Console.WriteLine(number2);
}
// на всякий случай - проверяем, что они не равны
else if (number2 == number1)
{
    Console.Write("Вы ввели одинаковые числа");
}
else
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(number2);
    Console.Write("Минимальное число: ");
    Console.WriteLine(number1);
}