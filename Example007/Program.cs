// Написать программу, которая обменивает элементы первой строки и последней строки
int[,] matrix = {
    { 2, 3, 6, 3 },
    { 2, 7, 2, 3 },
    { 2, 3, 6, 3 },
    { 1, 3, 6, 4 }
};

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

matrix = Elementfirstrowelementlastrow(matrix);
PrintArray(matrix);

