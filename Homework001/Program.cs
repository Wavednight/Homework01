void main (int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("Число кратно и 7, и 23.");
    }
    else
    {
        Console.WriteLine("Число не кратно одновременно 7 и 23.");
    }

    Console.ReadLine();
}

main(50);
main(322);
main(7);
main(322);