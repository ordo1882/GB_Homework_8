// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

void BuildHelix() // Реализация функци алгоритма построения спирали любого размера и формы.
{
    int startRow = 0, endRow = 0, startColumn = 0, endColumn = 0; // Точки излома прямоугольника массива (поворота). 
        
    int k = 1; // Переменная, которой будет заполняться массив.
    int i = 0; // Координаты строк.
    int j = 0; // Координаты столбцов.

    while (k <= rows * columns)
    {
        matrix[i, j] = k;
        if (i == startRow && j < columns - endColumn - 1) // Если у нас верхняя сторона прямоугольника и мы не достигли правой стороны, то двигаемся вправо.
            ++j;
        else if (j == columns - endColumn - 1 && i < rows - endRow - 1) // Если мы на правой стороне прямоугольника и не достигли нижней стороны, то двигаемся вниз.
            ++i;
        else if (i == rows - endRow - 1 && j > startColumn) // Если мы на нижней стороне прямоугольника и не достигли левой стороны, то двигаемся влево.
            --j;
        else // Иначе двигаемся вверх.
            --i;

        if ((i == startRow + 1) && (j == startColumn) && (startColumn != columns - endColumn - 1))
        // В конце же каждого прохода проверяем, завершился ли прямоугольник и стои ли начинать прочерчивать новый - меньший:
        // Если мы находимся на второй строке;
        // Если мы находимся на первом столбце;
        // И, в случае, если чертим не прямоугльник, а вертикальную линию, если первая строка не равна последней.
        // Тогда увеличиваем отступы от краев первого прямоугольника.
        {
            ++startRow;
            ++endRow;
            ++startColumn;
            ++endColumn;
        }
        ++k;
    }
}

BuildHelix(); // Вызов функци алгоритма построения спирали любого размера и формы.

void PrintArray()
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j] + " ");
            }
            else
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
PrintArray();
Console.WriteLine();