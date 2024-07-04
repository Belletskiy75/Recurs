// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

int i = 3;
int j = 6;

int Ackermann(int i, int j)
{
    if (i == 0)
        return j + 1;
    else if (i > 0 && j == 0)
        return Ackermann(i - 1, 1);
    else
        return Ackermann(i - 1, Ackermann(i, j - 1));
}
Console.WriteLine($"Ackermann({i}, {j}) = {Ackermann(i, j)}");

