// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int[,] matrix = new int [3, 4];
int[,] FillArray(int [,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = (new Random()).Next(1,10);
            Console.Write(matr[i,j] + " ");
        }
        Console.WriteLine();
    }
    return matr;
}


void MeanColumns(int [,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i,j];
        }
        Console.WriteLine(sum/matr.GetLength(0));
    }
}
matrix = FillArray(matrix);
Console.WriteLine();
MeanColumns(matrix);