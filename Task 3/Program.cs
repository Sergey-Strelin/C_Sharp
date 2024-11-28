// ввод данных
Console.Write("Введите любое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

// проверяем на чётность
Console.WriteLine((Single)number1/2);
Console.WriteLine(number1/2);

if ((Single)number1/2 == number1/2)
{
    Console.WriteLine("Вы ввели чётное число");
}
else
{
    Console.WriteLine("Вы ввели НЕ чётное число");
}