Random rnd = new Random();

int[] weightOfGroup = new int[10];

for (int i = 0; i < 10; i++)
{
    weightOfGroup[i] = rnd.Next(50, 150);
}

Console.Write("Масса каждого члена группы: ");
foreach (int weight in weightOfGroup)
{
    Console.Write($"{weight}, ");
}
Console.WriteLine($"\n\nМасса самого тяжелого из группы: {weightOfGroup.Max()}");
Console.WriteLine($"\nМасса самого легкого из группы: {weightOfGroup.Min()}");

if (weightOfGroup.Max() / 2 > weightOfGroup.Min())
{
    Console.WriteLine("\nМасса самого тяжелого из группы превышает массу самого легкого более чем в 2 раза");
}
else
{
    Console.WriteLine("\nМасса самого тяжелого из группы не превышает массу самого легкого более чем в 2 раза");
}