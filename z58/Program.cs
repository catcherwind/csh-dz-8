Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int arrayRows, int arrayColumns)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(-10, 10);
        }
    }
    return filledArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] firstArray, int[,] secomdArray, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secomdArray[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}


int[,] array1 = FillArray(rows, columns);
int[,] array2 = FillArray(rows, columns);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
int[,] resultArray = new int[rows, columns];
MultiplyMatrix(array1,array2, resultArray);
PrintArray(resultArray);