// метод выходного дня
void WeekEnd(int num)
{
    if (num == 0 || num > 7)
    {
        Console.WriteLine("Вы уверенны, что у Вас столько дней в неделе?");
    }
    else
    {
        Console.Write("Это выходной день? ");
        if (num == 6 || num == 7)
        {
            Console.WriteLine ("Да!");
        }
        else
        {
            Console.WriteLine("Нет :-(");
        }
    }
}

// ввод данных
Console.Write("Ведите номер дня недели: ");
//вызываю метод
WeekEnd(Convert.ToInt32(Console.dLineRea()));