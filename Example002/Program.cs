// Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] A = new int[m, n];

int[,] WorkArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = i + j;
        }
    }
    return A;
}
int[,] PrintArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write(A[i,j] + " ");
        }
        Console.WriteLine();
    }
    return A;
}

A = WorkArray(A);
A = PrintArray(A);