// Создать базовый класс и 2-3 его наследника
// В классе 2-4 свойства и пара методов
// Необходимо добавить поля и методы, и определить какие будут в базовом классе, какие в наследниках, какие потребуется перегрузить

using Task8;

HousePlant[] plants = {
            new Fern("Нефролепис", 25),
            new Orchid("Фаленопсис", "белый"),
            new Cactus("Цереус", 15, true)
};

foreach (var plant in plants)
{
    Console.WriteLine("\n=== Информация ===");
    plant.PrintInfo();
    plant.Water();
    plant.DisplayCareInstructions();
    plant.Photosynthesize();

    switch (plant)
    {
        case Cactus cactus:
            cactus.CheckForBlooming();
            break;
        case Orchid orchid:
            orchid.CheckRoots();
            break;
    }
}