namespace Task8;

/// <summary>
/// Класс Папоротник
/// </summary>
public class Fern : HousePlant
{
    public int FrondCount { get; set; }

    public Fern(string name, int frondCount)
    {
        Name = name;
        WateringFrequencyDays = 3;
        FrondCount = frondCount;
        IsBlooming = false;  // Папоротники не цветут
    }

    public override void Water()
    {
        Console.WriteLine($"{Name} любит влажность! Опрыскивайте листья.");
    }

    public override void DisplayCareInstructions()
    {
        Console.WriteLine($"Уход за {Name}:");
        Console.WriteLine("- Держите в тени, избегайте прямого солнца.");
        Console.WriteLine($"- Количество листьев: {FrondCount}");
    }
}