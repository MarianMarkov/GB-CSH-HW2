a = int.Parse(Console.ReadLine()!);
if (a / 100 == 0)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
    while (a / 1000 != 0)
    {
        a = a / 10;
    }
    Console.WriteLine((a % 100) % 10);
}
