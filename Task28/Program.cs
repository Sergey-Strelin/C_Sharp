// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.  

// M = 1; N = 15 -> 120  
// M = 4; N = 8. -> 30  


int Summa(int n, int m)
{
    //int summaNM = 0;
    if (n == m)
    {
        return n;
    }
    return n + Summa(n+1,m);

}

// задаём начальнык значения
Console.Write("Введите начальное число : ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число : ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Summa(numberN, numberM));