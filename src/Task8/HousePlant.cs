namespace Task8;

/// <summary>
/// Класс описывающий комнатные растения
/// </summary>
public abstract class HousePlant
{
    public string Name { get; set; }
    public int WateringFrequencyDays { get; set; }
    public bool IsBlooming { get; protected set; }

    /// <summary>
    /// Полив растений
    /// </summary>
    public abstract void Water();
    
    /// <summary>
    /// Инструкции по уходу
    /// </summary>
    public abstract void DisplayCareInstructions();

    public virtual void Photosynthesize()
    {
        Console.WriteLine($"{Name} поглощает свет и выделяет кислород.");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name}");
        Console.WriteLine($"Полив: каждые {WateringFrequencyDays} дней");
        Console.WriteLine($"Цветет сейчас: {(IsBlooming ? "Да" : "Нет")}");
    }
}