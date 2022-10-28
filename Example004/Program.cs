// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
Console.WriteLine("Введите число ");
int Number = int.Parse(Console.ReadLine());
int[,] Array = new int[,] { { 1, 2, 3 }, { 3, 4, 3 }, { 5, 6, 3 }, { 3, 8, 4 } };

void NumberPosition(int[,] Array, int Number)
{
    bool flag = false;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Number == Array[i, j])
            {
                flag = true;
                Console.WriteLine("Строка " + (i + 1) + " Столбец " + (j + 1));
            }
        }
    }
    if(flag == false) {
        Console.WriteLine("Такого элемента нет");
    }
}
NumberPosition(Array, Number);