// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int[,] matrix = {
    { 2, 3, 6, 3 },
    { 2, 7, 2, 3 },
    { 2, 3, 6, 3 },
    { 1, 3, 6, 4 }
};

int[] MeanColumns(int [,] matr)
{
    int[] result = new int[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i,j];
        }
        result[j] = sum;
    }
    return result;
}

void PrintArray(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        Console.WriteLine("Сумма элементов столбца №" + (i + 1) + " равна " + arr[i]);
    }
}

PrintArray(MeanColumns(matrix));
