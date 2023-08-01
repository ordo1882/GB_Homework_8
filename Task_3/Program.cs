// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] matrix1 = new int[rows, columns];
int[,] matrix2 = new int[columns, rows];
int[,] resultMatrix = new int[rows, rows]; // Массив для результирующей матрицы.

int[,] FillArray(int[,] matrix) // Реализация функции заполнения массива и суммирования элементов строк.
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

int[,] PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}

void MultiplytMatrix() // Реализация функции произведения матриц.
{
    for (int i = 0; i < matrix1.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix2.GetLength(1); ++j)
        {
            for (int k = 0; k < matrix2.GetLength(0); ++k)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
}

FillArray(matrix1); // Вызов функции заполнения массива первой матрицы.
FillArray(matrix2); // Вызов функции заполнения массива второй матрицы.
Console.WriteLine();
Console.WriteLine("Matrix 1");
PrintArray(matrix1); // Вывод первой матрицы.
Console.WriteLine();
Console.WriteLine("Matrix 2");
PrintArray(matrix2); // Вывод второй матрицы.
Console.WriteLine();
Console.WriteLine("Result Matrix");
MultiplytMatrix(); // Вызов функции произведения матриц.
PrintArray(resultMatrix); // Вывод результирующей матрицы.