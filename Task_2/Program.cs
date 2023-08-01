// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Enter number of rows:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of columns:");
int columns = Convert.ToInt32(Console.ReadLine());

void PromptIsValid() // Реализация функции проверки минимально допустипых данных.
{
    if (rows < 2 || columns < 2)
    {
        Console.WriteLine("Numbers are too small.");
        Environment.Exit(0);
    }
}

PromptIsValid(); // Вызов функции проверки минимально допустипых данных.

int[,] matrix = new int[rows, columns];
int[] eachRowSum = new int[matrix.GetLength(0)]; // Массив для сумм элементов строк.

void FillArray() // Реализация функции заполнения массива и суммирования элементов строк.
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + " ");

            if (j == 0)
            {
                eachRowSum[i] = matrix[i, j];
            }
            else
            {
                eachRowSum[i] += matrix[i, j];
            }
        }
        Console.WriteLine($" | {eachRowSum[i]}");
    }
}

void FindMinRow() // Реализация функции нахождения строки с наименьшей суммой.
{
    int minValue = eachRowSum[0];
    int minRow = 0;

    for (int i = 1; i < eachRowSum.Length; ++i)
    {
        if (minValue > eachRowSum[i])
        {
            minValue = eachRowSum[i];
            minRow = i;
        }
    }

    Console.WriteLine($"Row {minRow} has the smallest sum of numbers.");
}

Console.WriteLine();
FillArray(); // Вызов функции заполнения массива и суммирования элементов строк.
Console.WriteLine();
FindMinRow(); // Вызов функции нахождения строки с наименьшей суммой.
Console.WriteLine();