// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintNumbRecurs(int i, int j)
{
    if (i > j) return;
    {
        Console.Write(i + " ");
        PrintNumbRecurs(i +1, j);
    }

}
PrintNumbRecurs(1, 10);






