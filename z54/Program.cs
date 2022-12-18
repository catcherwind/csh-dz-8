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

int[,] SortArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
                {
                    if (array[i,j] > array[i,j + 1]){
                                temp = array[i,j];
                                array[i,j] = array[i,j+1];
                                array[i, j+1] = temp;
                    }     
                }
        }
        
    }
    return array;
}

int[,] array = FillArray(rows, columns);
PrintArray(array);
int[,] sortArray = SortArray(array);
Console.WriteLine();
PrintArray(sortArray);