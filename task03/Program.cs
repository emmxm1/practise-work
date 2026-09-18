int h = int.Parse(Console.ReadLine());

if (h >= 0 && h < 6)
{
    Console.WriteLine("Доброї ночі!");
}
else if (h < 12)
{
    Console.WriteLine("Доброго ранку!");
}
else if (h < 18)
{
    Console.WriteLine("Добрий день!");
}
else
{
    Console.WriteLine("Добрий вечір!");
}
