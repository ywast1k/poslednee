//  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30

int InputNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}


int PrintNumbers(int start, int end)
{
if (start == end){return start;} 
    {
    return start + PrintNumbers(start + 1,end);
    }
   
}

int first = InputNum("введите число M: ");
int second = InputNum("введите число N: ");

PrintNumbers(first,second);
int sum = PrintNumbers(first,second);
Console.WriteLine(sum);