// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4  
// 3 2 | 3 3  
// Результирующая матрица будет:  
// 18 20  
// 15 18

// создаём матрицу m*n и заполняем случайными положительными целыми числами от 0 до +99
int[,] GetArray(int m, int n)
{
    int[,] newArray = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i,j] = new Random().Next(0,100);
        } 
    }
    return newArray;
}


// выводим содержимое матрицы на экран
void ViewArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        } 
        Console.WriteLine();
    }

}

// умножаем первую матрицу на вторую
int [,] MultiplicationArrayOneTwo(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrixMultiplication = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    int numberSoglasovanieMatrix = matrixOne.GetLength(1);
    
    for (int i=0; i < matrixOne.GetLength(0); i++)
    {
        for (int j=0; j < matrixTwo.GetLength(1); j++)
        {
            matrixMultiplication[i,j] = 0;
            for (int k = 0; k < numberSoglasovanieMatrix; k++)
            {
                matrixMultiplication[i,j] += matrixOne[i,k] * matrixTwo[k,j];
            }
        }
    }
    return matrixMultiplication;
}



// задаём размер первой матрицы
Console.Write("Введите количество строк в первой матрице: ");
int rowsOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в первой мартице: ");
int columbsOne = Convert.ToInt32(Console.ReadLine());

int[,] arrayOne = GetArray(rowsOne, columbsOne); // создаём и заполняем первую матрицу

// задаём размерность второй матрицы
// надо учитывать, что перемножить можно только те матрицы у которых выполняется равенство:
// число столбцов первой мартицы равно числу строк второй матрицы
// по этому для второй спрашиваем только количество столбцов
int rowsTwo = columbsOne; // приравниваем для получения заведомо согласованных матриц!!!
Console.Write("Введите количество столбцов во второй мартице: ");
int columbsTwo = Convert.ToInt32(Console.ReadLine());
int[,] arrayTwo = GetArray(rowsTwo, columbsTwo ); // создаём и заполняем второй массив 

Console.WriteLine("Первая матрица: ");
ViewArray(arrayOne);                       // выводим первую матрицу на экран
Console.WriteLine("Вторая матрица: ");
ViewArray(arrayTwo);                       // выводим вторую матрицу на экран

// задаём размеры итоговой мартицы
int[,] arrayMultiplication = new int[columbsOne, columbsTwo]; 

// вычисляем произведение первой матрицы на вторую
arrayMultiplication = MultiplicationArrayOneTwo(arrayOne, arrayTwo);

Console.WriteLine("Итоговая матрица (произведение первой на вторую): ");
ViewArray(arrayMultiplication);            // выводим произведение матриц на экран