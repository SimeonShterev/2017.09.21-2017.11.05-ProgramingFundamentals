using System;

class Mine
{
    static void Main()
    {
        int yield = int.Parse(Console.ReadLine());
        int coal = 0;
        int days = 0;

        while (yield >= 100)
        {
            days++;
            coal += yield;
            yield -= 10;
            coal -= 26;
        }
        coal -= 26;
        if (coal < 0) coal = 0;

        Console.WriteLine(days);
        Console.WriteLine(coal);
    }
}