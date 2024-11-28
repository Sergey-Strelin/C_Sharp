// ограничение ввведения в 1000 установлено для ограничения количества
// выводимых результатов
// для проверки работы программы даже этого много...
// программа не такая как на семинаре.... но в примере задания вывод значений 
// кубов сделан в строку через запятую вот и реализовал строго как в примере к задаче!

// метод заполнения массива кубами чисел
void Degree(string num)
{
   // заполняем массив кубами чисел
   int [] thirdNumber = new int[Convert.ToInt32(num)];
   int count = 0;
   while (count < Convert.ToInt32(num))
   {
        thirdNumber[count] = (count + 1) * (count + 1) * (count + 1);
        count ++;
   }
   // печатаем полученные данные в строку
    count = 0;
    while (count < thirdNumber.Length)
    {
        Console.Write(thirdNumber[count]);
        count ++;
        // подавляем вывод последней запятой
        if (count < thirdNumber.Length)
        {
            Console.Write(", ");
        }
    }
}


// ввод данных
Console.Write("Введите натуральное число от 1 до 1000: ");
string numb = Console.ReadLine();

// Проверяем что введено число из диапазона
if ( Convert.ToInt32(numb) >= 1 && Convert.ToInt32(numb) <= 1000 ) 
{
    // вызов метода
    Degree(numb);
}
else
{
    Console.WriteLine("Вы ввели не допустимое число!");
}