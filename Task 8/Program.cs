// данный алгоритм работает с целыми числами любой длины, в том числе и 5 значными
// в цикле не проверяется, что дошли до середины числа, ввиду отсутствия 
// необходимости оптимизации кода и экономии процессорного времени

// хотелось бы узнать как убрать предупреждение 

//метод определения является ли число палиндромом
void Palindrom(String number)
{
    // проверяем число
    int count = 0;
    Console.WriteLine("Число является палиндромом? ");
    while (count < number.Length/2 )
    {   
        // если находим не соответствие - заканчиваем проверку
        if (number[count] != number[number.Length-count-1])
        {
            Console.WriteLine("Нет");
            // присваем счётчику значение больше длинны числа
            count = number.Length + 1;
            return;
        }
        count ++ ;
    }
    // проверяем причину окончания цикла
    if (count == number.Length/2)
    {
        Console.WriteLine("Да");
    }
}
