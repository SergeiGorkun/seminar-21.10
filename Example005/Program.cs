// В матрице чисел найти сумму элементов главной диагонали

int[,] arr = {
    { 2, 3, 6, 3 },
    { 2, 7, 2, 3 },
    { 2, 3, 6, 3 },
    { 1, 3, 6, 4 }
};

int getDiagonalSum(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, i];
    }
    return sum;
}

Console.WriteLine(getDiagonalSum(arr));