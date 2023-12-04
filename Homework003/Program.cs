int MaxDigit(int number)
{
    int max = 0;
    while (number !=0)
    {
        int digit = number % 10;
        number /= 10;
        if (digit > max)
        {
            max = digit;
        }
    }
    return max;
}
int num = 78;

Console.WriteLine("Source = " + num);
Console.WriteLine($"Max digit is {MaxDigit(num)}");