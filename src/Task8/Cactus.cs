namespace Task8;

/// <summary>
/// Класс Кактус
/// </summary>
public class Cactus : HousePlant
{
    public int SpineLengthMm { get; set; }  // Длина колючек в мм
    public bool IsDesertType { get; set; }  // Пустынный кактус (true) или лесной (false)?

    public Cactus(string name, int spineLengthMm, bool isDesertType)
    {
        Name = name;
        WateringFrequencyDays = isDesertType ? 30 : 14;  // Пустынные поливают реже
        SpineLengthMm = spineLengthMm;
        IsDesertType = isDesertType;
        IsBlooming = false;  // Цветет только при идеальных условиях
    }

    public override void Water()
    {
        Console.WriteLine(IsDesertType
            ? $"{Name} поливают очень редко (раз в {WateringFrequencyDays} дней)."
            : $"{Name} поливают раз в {WateringFrequencyDays} дней, как суккулент.");
    }

    public override void DisplayCareInstructions()
    {
        Console.WriteLine($"Уход за {Name}:");
        Console.WriteLine($"- Тип: {(IsDesertType ? "Пустынный" : "Лесной")}");
        Console.WriteLine($"- Длина колючек: {SpineLengthMm} мм");
        Console.WriteLine("- Максимум света, особенно зимой.");
    }

    /// <summary>
    /// Метод проверки цветение кактуса
    /// </summary>
    public void CheckForBlooming()
    {
        if (new Random().Next(0, 10) == 0)  // 10% шанс цветения
        {
            IsBlooming = true;
            Console.WriteLine($"Удивительно! {Name} решил зацвести 🌵🌸");
        }
        else
            Console.WriteLine($"{Name} пока не цветет. Попробуйте уменьшить полив зимой.");
    }
}
