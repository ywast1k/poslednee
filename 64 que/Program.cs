int InpuntNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

void PrintNumbers(int num)
{
if (num == 0) return;
Console.Write(num + " ");
PrintNumbers(num - 1);

}

int number = InpuntNum("Введите число N: ");
PrintNumbers(number);
Console.WriteLine();
