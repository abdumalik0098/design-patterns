using Iterator.Lib;

IDetalPart part = new FixDetalPart(3345, 4);

part.AddDetal(new DetalItem()
{
    ID = 8834,
    Name= "Bolt",
    Massa = 300,
    Material = "Iron"
});
part.AddDetal(new DetalItem()
{
    ID = 3467,
    Name= "Gayka",
    Massa = 237.9F,
    Material = "Iron"
});
part.AddDetal(new DetalItem()
{
    ID = 387,
    Name= "Пружина",
    Massa = 89.9F,
    Material = "Золото"
});

Console.WriteLine("Part 1:");
Print(part);

part.MoveDetalToDefective(3467);
Console.WriteLine($"Defect - 2 detal:\n");
Print(part);

Console.WriteLine(new String('-',30));


IDetalPart part2 = new ArbitraryDetalPart();

part2.AddDetal(new DetalItem()
{
    ID = 45,
    Name = "Bolt 234",
    Massa = 453,
    Material = "Iron"
});
part2.AddDetal(new DetalItem()
{
    ID = 789,
    Name = "Крепеж",
    Massa = 112.9F,
    Material = "Iron"
});
part2.AddDetal(new DetalItem()
{
    ID = 42,
    Name = "Пружина",
    Massa = 89.9F,
    Material = "Железо"
});

Console.WriteLine("Part 2:");
Print(part2);

part2.MoveDetalToDefective(45);
Console.WriteLine($"Defect - 1 detal:\n");
Print(part2);

void Print(IDetalPart detal)
{
    IDetalIterator iterator = detal.CreateDetalIterator();

    DetalItem firstDetal = iterator.GetFirstDetal();
    if (firstDetal != null)
    {
        Console.WriteLine(iterator.GetFirstDetal().ToString());
    }
    else Console.WriteLine("Empty\n");

    while (iterator.HasNextDetal() == true)
    {
        DetalItem item = iterator.GetNextDetal();
        if (item != null)
        {
            Console.WriteLine(item.ToString());
        }
        else Console.WriteLine("Empty\n");
    }
}