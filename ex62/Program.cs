//Напишите программу, которая заполнит спирально массив 4 на 4.

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

int[,] GetSpiral(int n)
{
    int[,] result = new int[n, n];
    int value = 1;
    for (int circleNum = 0; circleNum < n / 2 + n % 2; circleNum++) 
    {
        int circleQuarter = n - 2 * circleNum - 1; 
        int circleLength = Math.Max(4 * circleQuarter, 1);
        int row = circleNum;
        int column = circleNum;
        for (int i = 0; i < circleLength; i++)
        {
            result[row, column] = value;
            value++;
            if (i < circleQuarter)
                column++;
            else if (i < 2 * circleQuarter)
                row++;
                 else if (i < 3 * circleQuarter)
                    column--;
                      else            
                        row--;            
        }
    }
    return result;
}

Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
PrintMatrix(GetSpiral(n));
