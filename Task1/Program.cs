// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


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
            array[i, j] = rnd.Next(1, 20);
        }
    }
    return array;
}

void SrednArray(int[,] sredArray)
{
    for(int i = 0; i < sredArray.GetLength(0); i++)   
    {
      
        for(int j = 0; j < sredArray.GetLength(1); j++)
        {
              int maxIndex = j;
              for(int k = j; k < sredArray.GetLength(1); k++) 
            {
                  if(sredArray[i, k] > sredArray[i, maxIndex]) maxIndex = k;
            }
            if (sredArray[i,j] == sredArray[i,maxIndex]) continue;
            int temp = sredArray[i,j];
            sredArray[i,j] = sredArray[i,maxIndex];
            sredArray[i,maxIndex] = temp;
        } 
    }
}


int[,] array = FillArray(4, 5);
PrintArray(array);
SrednArray(array);
Console.WriteLine();
Console.WriteLine("Упорядочено: ");
PrintArray(array);
