// Написать программу, которая обменивает элементы первой строки и последней строки
int[,] matrix = new int[3, 4];
int[,] FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = (new Random()).Next(1, 10);
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matr;
}

int [,] Elementfirstrowelementlastrow(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int first = matr[0, j];
        int last = matr[matr.GetLength(0) - 1, j];

        matr[0, j] = last;
        matr[matr.GetLength(0) - 1, j] = first;
    }
    return matr;
}

void PrintArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write(A[i,j] + " ");
        }
        Console.WriteLine();
    }
}

matrix = FillArray(matrix);
Console.WriteLine();
matrix = Elementfirstrowelementlastrow(matrix);
PrintArray(matrix);

