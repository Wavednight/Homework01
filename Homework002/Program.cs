void main (int x, int y)
{
    Console.Write($"({x}, {y}) =>  ");
    if ((x == 0) || (y == 0))
    {
        Console.WriteLine("Ошибка: координаты не могут быть равны 0!");
    }
    else
    {
        if (y > 0)
        {
            // это первая или вторая четверть
            if (x > 0)
            {
                Console.WriteLine("1 Четверть");
            } else {
                Console.WriteLine("2 Четверть");
            }
        } else {
            // это третья или четвертая четверть
            if (x > 0)
            {
                Console.WriteLine("4 Четверть");
            } else {
                Console.WriteLine("3 Четверть");
            }
        }
    }
}


main(2, 3);
main(-5, 3);
main(-3, -2);
main(4, -2);