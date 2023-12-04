void showDigits(int num)
{
    int[] digits = new int[10];
    int count = 0;

    Console.WriteLine("Число: " + num);
    while (num != 0)
    {
        digits[count++] = num % 10;
        num /= 10;
    }

    while (count > 0)
    {
        Console.Write(digits[--count]);
        if (count != 0)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine();
}


showDigits(9542);
showDigits(8);
showDigits(568);