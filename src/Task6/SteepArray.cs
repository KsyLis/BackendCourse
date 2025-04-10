// Класс должен быть "обвязкой" для массива элементов типа int. И поддерживать следующие методы

// Инициализация массива (на вход подается массив А, элементами которого должен заполниться массив нашего класса)
// Получение элемента по индексу
// Получение размера массива (свойство)
// Добавление элемента в конец массива

// Вставка элемента по индексу, если есть элементы справа, то они должны сдвинуться
// Удаление элемента по индексу, со сдвигом остальных элементов.
// Сортировка массива по возрастанию/убыванию

namespace Task6;

/// <summary>
/// Класс с методами, для работы с массивом
/// </summary>
public static class SteepArray
{
    private static int[] _array;

    public static int Size {  get { return _array.Length; } }

    /// <summary>
    /// Метод для инициализации массива
    /// </summary>
    /// <param name="nums">Массив пользователя</param>
    public static void InitializingArray(int[] nums)
    {
        _array = new int[nums.Length];
        nums.CopyTo(_array, 0);
    }

    /// <summary>
    /// Метод получения элемента массива
    /// </summary>
    /// <param name="index">Индекс элемента</param>
    public static int GetItemByIndex(int index)
    {
        int arrayElement = 0;

        if (index >= 0 && index < _array.Length)
        {
            arrayElement = _array[index];
        }
        else
        {
            Console.WriteLine("Индекс вне границ массива");
        }
        return arrayElement;
    }

    /// <summary>
    /// Метод добавления элемента в конец
    /// </summary>
    /// <param name="num">Добавляемое число</param>
    public static void AddingToEnd(int num)
    {
        int[] nums = new int[_array.Length + 1];

        _array.CopyTo(nums, 0);

        nums[^1] = num;

        _array = nums;
    }

    /// <summary>
    /// Метод Вставка элемента по индексу
    /// </summary>
    /// <param name="index">Индекс пользователя</param>
    /// <param name="element">Элемент пользователя</param>
    public static void InsertingAnElementByIndex(int index, int element)
    {
        if (index == _array.Length - 1)
        {
            AddingToEnd(element);
            return;
        }
        
        int[] nums = new int[_array.Length + 1];

        _array.CopyTo(nums, 0);

        int prev = _array[index];

        nums[index] = element;

        int buff = 0;

        for (int i = index + 1; i < nums.Length; i++)
        {
            buff = nums[i];

            nums[i] = prev;

            prev = buff;
        }

        _array = nums;
    }
}
