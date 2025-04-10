// Необходимо написать статический класс для работы с массивом
// Класс должен быть "обвязкой" для массива элементов типа int. И поддерживать следующие методы (описание в классе SteepArray)

using Task6;

var arr = new int[] {1, 2, 3, 4};

SteepArray.InitializingArray(arr);

var result = SteepArray.GetItemByIndex(2);

SteepArray.AddingToEnd(8);

SteepArray.InsertingAnElementByIndex(4, 7);