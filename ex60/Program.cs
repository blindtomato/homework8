//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.

int[,,] FillMatrix(int m1, int m2, int m3)
{
    int[,,] matrix = new int[m1, m2, m3];
    int[] generated = GetUniqNumbers(m1 * m2 * m3);
    int l = 0;
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < m2; j++)
        {
            for (int k = 0; k < m3; k++)
            {
                matrix[i, j, k] = generated[l];
                l++;
            }            
        }
    }
    return matrix;
}

int[] GetUniqNumbers(int n)
{
    int[] result = new int [n];
    for (int i = 0; i < n; i++)
    {
        result[i] = new Random().Next(10, 100);
        int j = 0;
        while (j < i)
        {
            if (result[i] == result[j])
            {
                result[i] = new Random().Next(10, 100);
                j = 0;
            }
            else    
                j++;   
        }
    }
    return result;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) \t");
            }            
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите первый размер трехмерного массива");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй размер трехмерного массива");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третий размер трехмерного массива");
int m3 = Convert.ToInt32(Console.ReadLine());

if (m1 * m2 * m3 > 90)
    Console.WriteLine("Количество элементов в массиве превышает количество двузначных чисел");
else
{
    int[,,] matrix = FillMatrix(m1, m2, m3);
    Console.WriteLine();
    PrintMatrix(matrix);
}

