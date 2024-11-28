// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.*  
// m = 2, n = 3 -> A(m,n) = 9  
// m = 3, n = 2 -> A(m,n) = 29 

int Akkerman( int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Akkerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    } 
    else
    return n + 1;
}



// задаём коэффициенты
Console.Write("Введите первое число ( от 0 до 3): ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число (от 0 до 5): ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM <= 3 && numberN <= 5)         // учитывая скорость нарастания функции - ограничим входные коэффициенты
{
    Console.WriteLine(Akkerman(numberM, numberN));
}
else
{
    Console.WriteLine("Введите числа в указанных диапазонах");
}