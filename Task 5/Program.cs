// метод выделения 2 цифры из трёхзначного числа
void DecimalView(int num)
{
    Console.Write("Вторая цифра в этом числе: ");
    Console.WriteLine(Math.Abs((num % 100 - num % 10) / 10));
}

// вводим число
Console.Write("Ведите целое трёх значное число: ");
//вызываю метод
DecimalView(Convert.ToInt32(Console.ReadLine()));