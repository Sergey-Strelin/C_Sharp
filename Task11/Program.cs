// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B

//метод возведения в степень
double Exponentiation(int X, int Y)
{
    int Exp = X;
    if (Y > 0)
    {
        int count = 1;
        while (count < Y)
        {
            Exp = Exp*X;
            count ++;
        }
    }
    else if (Y == 0) Exp = 1;
    return Exp;
}

// ввод данных
Console.Write("Введите основание степени x = ");
int x = Convert.ToInt32(Console.ReadLine() );
Console.Write("Введите аргумент степени y = ");
int y = Convert.ToInt32(Console.ReadLine() );
if (y >= 0) // проверяем, что аргумент не отрицательный
{
    // вызов метода и вывод результата на экран
    Console.WriteLine($"{x} в степени {y} равно {Exponentiation(x,y)}");
}
else Console.WriteLine("Аргумент степени не должен быть отрицательным!");