// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Enter the first number:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the first number:");
int columns = Convert.ToInt32(Console.ReadLine());

void PromptIsValid() // Реализация функции проверки минимально допустипых данных.
{
    if (rows < 2 || columns < 2)
    {
        Console.WriteLine("Nubers are too small.");
        Environment.Exit(0);
    }
}

PromptIsValid(); // Вызов функции проверки минимально допустипых данных.

int[,] matrix = new int[rows, columns];

void FillArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void SortArray() // Реализация функции сортировки элементов массива.
{
    int minValue = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    minValue = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = minValue;
                }
            }
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillArray();
Console.WriteLine();
PrintArray();
Console.WriteLine();
SortArray(); // Вызов функции сортировки элементов массива.
PrintArray();