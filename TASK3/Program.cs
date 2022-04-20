// Задача 3: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray2(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] FillArray2(int row, int column)
{
    int[,] array2 = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = rnd.Next(1, 10);
        }
    }
    return array2;
}

int[,] SrednArray(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)]; 
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}



int[,] array = FillArray(2, 3);
PrintArray(array);
Console.WriteLine();
int[,] array2 = FillArray2(3, 3);
PrintArray2(array2);
SrednArray(array);
Console.WriteLine();
PrintArray(array);