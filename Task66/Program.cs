Console.Write("Введите число M:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:");
int numN = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int numM, int numN)
{
    int sum = 0;
    if (numM < numN)
    {
        sum += SumOfDigits(numM+1,numN);
    }
    return sum+numM;
}

int totalAmount = SumOfDigits(numM,numN);
Console.WriteLine($"{totalAmount}");



