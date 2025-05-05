// Файл Market.csv содержит информацию о магазинах, товарах в магазинах и проданных товарах, а так же цену товара
// Необходимо реализовать следующие возможности:
// Добавить товар в магазин, к имеющемуся кол-ву на складе
// Кол-во проданного товара, с учетом текущих продаж
// Информация о выручке магазинов в порядке убывания
// Сохранить текущее состояние файла посредством перезаписи или созданием нового

using Task9;

List<Shop> file = FileOperations.ReadFile("Market.csv");

file[1].AddItemToWarehouse(5, ProductType.Apples);
    
file[3].AddQuantityOfProductSold(3, ProductType.Apples);

for (int i = 0; i < file.Count; i++)
{
    file[i].CalculateStoreRevenues();
}

var r = file.OrderByDescending(x => x.Revenue).ToList();

Console.WriteLine("Выручка магазинов в порядке убывания");

foreach (var item in r)
{
    Console.WriteLine("{0}: {1}", item.Name, item.Revenue); 
}

FileOperations.CreateFile(file);