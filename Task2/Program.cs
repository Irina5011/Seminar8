// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 
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
 
void MinSum (int[,] array)
{
    int[] sumLine = new int[array.GetLength(0)];
    for(int i = 0; i< array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j=0; j<array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        sumLine[i] = sum;
    }
    int minimumSum = sumLine[0];
    int indexMinisum = 0;
    for(int i = 1; i< sumLine.Length; i++)
    {
        if(sumLine[i] < minimumSum)
        {
            minimumSum = sumLine[i];
            indexMinisum = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {indexMinisum}");
    Console.WriteLine($"Сумма =  {minimumSum}");
}


 
int[,] array = FillArray(3, 4);
PrintArray(array);
Console.WriteLine();
MinSum(array);