// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2  
// 66(0,0,0) 25(0,1,0)  
// 34(1,0,0) 41(1,1,0)  
// 27(0,0,1) 90(0,1,1)  
// 26(1,0,1) 55(1,1,1)



// создаём трёхмерную матрицу и заполняем неодинаковыми положительными двухзначными целыми числами
int[,,] GetArray(int x, int y, int z)
{
    int[,,] newArray = new int[x,y,z];
    int number = 10;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int n = 0; n < z; n++)
            {
                newArray[i,j,n] = number;
                number ++;
            }
        } 
    }
    return newArray;
}


// выводим содержимое матрицы на экран
void ViewArray (int[,,] array)
{
    Console.WriteLine($"Получившийся массив :");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write($"{array[i,j,n]}({i},{j},{n}) \t");
            }
            Console.WriteLine();
        } 
        Console.WriteLine();
    }

}


// задаём размер первой матрицы
Console.Write("Введите первую размерность массива: ");
int osOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность массива: ");
int osTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью размерность массива: ");
int osThree = Convert.ToInt32(Console.ReadLine());
if (osOne * osTwo * osThree > 89)
{
    Console.WriteLine("Необходимо ввести размеры массива, произведение которых");
    Console.WriteLine("будет меньше 90!!!");
}
else
{
    int[,,] array = GetArray(osOne, osTwo, osThree); // создаём и заполняем матрицу
    ViewArray(array);                                // выводим матрицу на экран
}