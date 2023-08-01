// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Enter number of elements for the 1st level:");
int firstLevel = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of elements for 2nd level:");
int secondLevel = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of elements for 3rd level:");
int thirdLevel = Convert.ToInt32(Console.ReadLine());

void PromptIsValid() // Реализация функции проверки минимально допустипых данных и размера массива.
{
    if (firstLevel < 2 || secondLevel < 2 || thirdLevel < 2)
    {
        Console.WriteLine("Numbers are too small.");
        Environment.Exit(0);
    }
    else if ((firstLevel * secondLevel * thirdLevel) > 90)
    {
        Console.WriteLine("Array is too big");
        Environment.Exit(0);
    }
}

PromptIsValid(); // Вызов функции проверки минимально допустипых данных и размера массива.

int[,,] matrix = new int[firstLevel, secondLevel, thirdLevel]; // Создаем трехмерный массив.
int[] numbers = Enumerable.Range(0, 100).ToArray(); // Создаем массив упорядоченых уникальных чисел до 99 включительно.

void ShuffleArray() // Реализация функции перемешивания массива.
{
    for (int i = 0; i < numbers.Length; ++i)
    {
        int randomIndex = new Random().Next(numbers.Length);
        int temp = numbers[randomIndex];
        numbers[randomIndex] = numbers[i];
        numbers[i] = temp;
    }
}

ShuffleArray(); // Вызов функции перемешивания массива.

void FillMatrix() // Реализация функции заполнения трехмерного массива уже рандомными числами из массива numbers.
{
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            for (int k = 0; k < matrix.GetLength(2); ++k)
            {
            Repeat:
                if (numbers[count] > 9)
                {
                    matrix[i, j, k] = numbers[count];
                    Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
                    ++count;
                }
                else // Если число не двузначное, то пропускаем ячейку, инкрементируем count и проверяем условие заново.
                {
                    ++count;
                    goto Repeat;
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
FillMatrix(); // Вызов функции заполнения трехмерного массива уже рандомными числами из массива numbers.