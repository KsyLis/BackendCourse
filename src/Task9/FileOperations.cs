namespace Task9;

/// <summary>
/// Класс операций с файлом
/// </summary>
public static class FileOperations
{
    /// <summary>
    /// Метод чтения файла
    /// </summary>
    /// <param name="path">Путь к файлу</param>
    /// <returns></returns>
    public static List<Shop> ReadFile(string path)
    {
        var shops = new List<Shop>();

        using (StreamReader reader = new StreamReader(path))
        {
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var delimiter = reader.ReadLine().Split(',');

                var shop = new Shop
                {
                    Name = delimiter[0],
                    WarehouseSize = int.Parse(delimiter[1]),
                    ApplesPrice = int.Parse(delimiter[2]),
                    OrangesPrice = int.Parse(delimiter[3]),
                    ApplesWarehouse = int.Parse(delimiter[4]),
                    ApplesSold = int.Parse(delimiter[5]),
                    OrangesWarehouse = int.Parse(delimiter[6]),
                    OrangesSold = int.Parse(delimiter[7])

                };
                shops.Add(shop);
            }
        }
        return shops;
    }

    /// <summary>
    /// Метод создания файла
    /// </summary>
    public static void CreateFile(List<Shop> shops)
    {
        var fileContent = "Название,Размер склада,Яблоки,Апельсины,Яблоки - Склад,Яблоки - Продано,Апельсины - Склад,Апельсины - Продано\n";

        fileContent += string.Join('\n', shops);

        File.WriteAllText("Market1.csv", fileContent);
    }
}