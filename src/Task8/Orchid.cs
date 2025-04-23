namespace Task8;

/// <summary>
/// Класс Орхидея
/// </summary>
public class Orchid : HousePlant
{
    public string FlowerColor { get; set; }

    public Orchid(string name, string flowerColor)
    {
        Name = name;
        WateringFrequencyDays = 7;
        FlowerColor = flowerColor;
        IsBlooming = true;  // Орхидеи часто цветут
    }

    public override void Water()
    {
        Console.WriteLine($"{Name} поливают методом погружения горшка в воду.");
    }

    public override void DisplayCareInstructions()
    {
        Console.WriteLine($"Уход за {Name}:");
        Console.WriteLine("- Яркий, но рассеянный свет.");
        Console.WriteLine($"- Цвет: {FlowerColor}");
        Console.WriteLine("- Подкармливайте специальным удобрением для орхидей.");
    }

    /// <summary>
    /// Метод проверяющий корни растения
    /// </summary>
    public void CheckRoots()
    {
        Console.WriteLine("Проверьте воздушные корни: они должны быть серебристо-зелёными.");
    }
}