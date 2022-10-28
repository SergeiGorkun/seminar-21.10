// Показать двумерный массив размером m×n заполненный вещественными числами

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
float[,] matrix = new float[m, n];

float[,] FillArray(float[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] =  (float) (new Random()).Next(0, 100) / 100;
        }

    }
    return matrix;

}

void PrintArray(float[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

matrix = FillArray(matrix);
PrintArray(matrix);