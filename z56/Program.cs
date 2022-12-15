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

(int,int) SearchMinStrArray(int[,] array)
{
    int sum = 0;
    int minSum = 100000000;
    int numStr = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if (sum < minSum){
            numStr = i;
            minSum = sum;
        }
    }
    return (numStr, minSum);
}



int[,] array = FillArray(rows, columns);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Самая минимальная сумма в строке {SearchMinStrArray(array).Item1}. Она равна {SearchMinStrArray(array).Item2}");