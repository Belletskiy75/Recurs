// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.


int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

void PrintArrayRecurs(int[] array, int i)
{
    if (i > 0)
    {
        Console.Write(array[i - 1] + " ");
        PrintArrayRecurs(array, i - 1);
    }
}

PrintArrayRecurs(array, array.Length);