namespace Task7;

/// <summary>
/// Класс описывающий cкрипку
/// </summary>
public class Violin
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public bool IsElectric { get; set; }
    public int Price { get; set; }

    public Violin(string brand, string model, int year, string color, bool isElectric, int price)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
        IsElectric = isElectric;
        Price = price;
    }

    /// <summary>
    /// Метод для отображения информации о скрипке
    /// </summary>
    public void DisplayInfo()
    {
        Console.WriteLine($"Скрипка: {Brand} {Model}");
        Console.WriteLine($"Год выпуска: {Year}");
        Console.WriteLine($"Цвет: {Color}");
        Console.WriteLine($"Тип: {(IsElectric ? "Электроскрипка" : "Акустическая скрипка")}");
        Console.WriteLine($"Цена: {Price:C}");
    }
}
