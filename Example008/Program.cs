// В прямоугольной матрице найти строку с наименьшей суммой элементов.
int[,] arr = {
    { 2, 3, 1, 3 },
    { 2, 0, 2, 1 },
    { 2, 3, 6, 3 }
};

int RowWithSmallestSum(int[,] arr)
{
    int minSum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if(minSum == 0 || sum < minSum) {
            minSum = sum;
        }
    }
    return minSum;
}

Console.WriteLine(RowWithSmallestSum(arr));
