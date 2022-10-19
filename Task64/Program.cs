Console.Write("Введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());

void PrintNumber(int numA)
{
    if (numA >= 1)
    {
        Console.Write($"{numA},");
        PrintNumber(numA - 1);
    }
    else
    {
        Console.Write($"{numA}");
    }
}
PrintNumber(numN);
Console.WriteLine();