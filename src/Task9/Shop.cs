namespace Task9;

/// <summary>
/// Класс, описывающий модель магазина из файла
/// </summary>
public class Shop
{
    /// <summary>
    /// Название магазина
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Размер склада
    /// </summary>
    public int WarehouseSize { get; set; }
    
    /// <summary>
    /// Цена яблок
    /// </summary>
    public int ApplesPrice { get; set; }
    
    /// <summary>
    /// Цена апельсинов
    /// </summary>
    public int OrangesPrice { get; set; }
    
    /// <summary>
    /// Кол-во яблок на складе
    /// </summary>
    public int ApplesWarehouse { get; set; }
    
    /// <summary>
    /// Кол-во проданных яблок
    /// </summary>
    public int ApplesSold { get; set; }
    
    /// <summary>
    /// Кол-во апельсинов на складе
    /// </summary>
    public int OrangesWarehouse { get; set; }
    
    /// <summary>
    /// Кол-во проданных апельсинов
    /// </summary>
    public int OrangesSold { get; set; }
    
    /// <summary>
    /// Выручка
    /// </summary>
    public int Revenue { get; set; }

    public override string ToString()
    {
        return $"{Name},{WarehouseSize},{ApplesPrice},{OrangesPrice},{ApplesWarehouse},{ApplesSold},{OrangesWarehouse},{OrangesSold} ";
    }

    /// <summary>
    /// Добавление товара на склад
    /// </summary>
    /// <param name="count">Кол-во добавляемого товара</param>
    /// <param name="productType">Тип товара</param>
    public void AddItemToWarehouse(int count, ProductType productType)
    {
        var freeSpace = WarehouseSize - (ApplesWarehouse + OrangesWarehouse);

        if (count > freeSpace)
        {
            Console.WriteLine("Для размещения на складе не достаточно места. Размер склада {0} единиц", freeSpace);
            return;
        }

        switch (productType)
        {
            case ProductType.Apples:
                ApplesWarehouse += count;
                break;
            case ProductType.Oranges:
                OrangesWarehouse += count;
                break;
        }
        
        Console.WriteLine("Товар добавлен на склад");
    }
    
    /// <summary>
    /// Добавление проданного товара
    /// </summary>
    /// <param name="count">Кол-во проданного товара</param>
    /// <param name="productType">Тип товара</param>
    public void AddQuantityOfProductSold(int count, ProductType productType)
    {
        if (count > ApplesWarehouse && productType == ProductType.Apples)
        {
            Console.WriteLine("Вы не можете продать товара больше, чем есть на складе");
            return;
        }
        else if (count > OrangesWarehouse && productType == ProductType.Oranges)
        {
            Console.WriteLine("Вы не можете продать товара больше, чем есть на складе");
            return;
        }

        switch (productType)
        {
            case ProductType.Apples:
                ApplesSold += count;
                ApplesWarehouse -= count;
                break;
            case ProductType.Oranges:
                OrangesSold += count;
                OrangesWarehouse -= count;
                break;
        }
        
        Console.WriteLine("Кол-во проданного товара добавлено");
    }

    /// <summary>
    /// Рассчет выручки магазинов
    /// </summary>
    public void CalculateStoreRevenues()
    {
        Revenue = ApplesPrice * ApplesSold + OrangesPrice * OrangesSold;
    }
}

/// <summary>
/// Тип товара
/// </summary>
public enum ProductType
{
    Apples,
    Oranges
}