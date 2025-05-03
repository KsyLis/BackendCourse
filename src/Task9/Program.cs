// Файл Market.csv содержит информацию о магазинах, товарах в магазинах и проданных товарах, а так же цену товара
// Необходимо реализовать следующие возможности:
// Добавить товар в магазин, к имеющемуся кол-ву на складе
// Кол-во проданного товара, с учетом текущих продаж
// Информация о выручке магазинов в порядке убывания
// Сохранить текущее состояние файла посредством перезаписи или созданием нового

using Task9;

string path = "Market.csv";

var shops = new List<Shop>();

using (StreamReader reader = new StreamReader(path))
{
    reader.ReadLine();
    
    while (!reader.EndOfStream)
    {
        var delimiter= reader.ReadLine().Split(',');

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

    shops[1].AddItemToWarehouse(5, ProductType.Apples);
    
    shops[3].AddQuantityOfProductSold(18, ProductType.Apples);
}

