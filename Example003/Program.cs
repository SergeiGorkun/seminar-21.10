// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] matrix = new int[4, 8];

int[,] FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (new Random().Next(3,22));
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}

void Psquaring(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0 && i > 0 && j > 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

matrix = FillArray(matrix);
Psquaring(matrix);