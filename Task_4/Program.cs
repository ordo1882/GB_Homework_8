// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Enter the first number:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the first number:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];

// void FillMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// FillMatrix();

// void SwapRowsFirstLast ()
// {
//     int tempRow = 0;

//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         tempRow = matrix[0, i];
//         matrix[0, i] = matrix[rows - 1, i];
//         matrix[rows - 1, i] = tempRow;
//     }
//     Console.WriteLine();
// }

// SwapRowsFirstLast();

// void PrintMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintMatrix();

//=================================================================

// Console.WriteLine("Enter the first number:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the first number:");
// int columns = Convert.ToInt32(Console.ReadLine());

// bool PromptIsValid(int a, int b)
// {
//     if (a == b)
//     {
//         return true;
//     }
//     else 
//     {
//         Console.WriteLine("Nubers have to be equal.");
//         return false;
//     }
// }

// int[,] FillMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }

// int[,] TurnMatrix(int[,] matrix)
// {
//     int tempRow = 0;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < matrix.GetLength(1); j++)
//         {
//             if(matrix[i, j] != matrix[j, i])
//             {
//                 tempRow = matrix[i, j];
//                 matrix[i, j] = matrix[j, i];
//                 matrix[j, i] = tempRow;
//             }
//         }
//     }
//     Console.WriteLine();
//     return matrix;
// }

// int[,] PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }

// if(PromptIsValid(rows, columns))
// {
//     int[,] newMatrix = new int[rows, columns];

//     FillMatrix(newMatrix);
//     TurnMatrix(newMatrix);
//     PrintMatrix(newMatrix);
// }

//==============================================================