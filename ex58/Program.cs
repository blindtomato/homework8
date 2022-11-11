//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] FillAndPrintMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 5);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();    
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiply(int[,] array1, int[,] array2)
{
    int m3 = array1.GetLength(0);
    int n3 = array2.GetLength(1);
    int[,] array3 = new int[m3, n3];
    for (int i = 0; i < m3; i++)
    {
        for (int j = 0; j < n3; j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
                array3[i, j] += array1[i, k] * array2[k, j];
        }
    }
    return array3;
}

Console.WriteLine("Введите количество строк первой матрицы");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы и строк второй матрицы");
int n1 = Convert.ToInt32(Console.ReadLine());
int m2 = n1;
Console.WriteLine("Введите количество столбцов второй матрицы");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = FillAndPrintMatrix(m1, n1);
Console.WriteLine();
int[,] matrix2 = FillAndPrintMatrix(m2, n2);
Console.WriteLine();

Console.WriteLine("Результат перемножения матриц");
PrintMatrix(MatrixMultiply(matrix1, matrix2));
