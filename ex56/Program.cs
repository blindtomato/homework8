//Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.

int[,] FillAndPrintMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();    
    }
    return matrix;
}

int FindRowWithMinSum(int[,] array)
{
    int numberRow = 0;
    int SumNumbers = 0;
    int SumNumbersNext = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        SumNumbers += array[0,j];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            SumNumbersNext += array[i,j];
        if (SumNumbersNext < SumNumbers)
        {
            SumNumbers = SumNumbersNext;
            numberRow = i;
        }
    }
    return numberRow;
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillAndPrintMatrix(m, n);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов {FindRowWithMinSum(matrix) + 1}");
