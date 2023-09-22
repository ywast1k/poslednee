﻿//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//  m = 2, n = 3 -> A(m,n) = 9
//  m = 3, n = 2 -> A(m,n) = 29

int InputNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}




int Akkerman( int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
        else if (n == 0 && m > 0)
        {
            return Akkerman(m - 1, 1);
        }
            else
            {
                return (Akkerman(m - 1, Akkerman(m, n - 1)));
            }
}


int first = InputNum("введите число M: ");
int second = InputNum("введите число N: ");

Akkerman(first, second);
Console.WriteLine(Akkerman(first,second));
