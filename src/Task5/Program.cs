// Пользователь вводит арабское число, на выходе получает римское
// Допустимый диапазон ввода арабских чисел от 1 до 3999

// Арабские = 1, 2, 3 и т.д
// Римские = I, II, III и т.д

// 1 - I
// 5 - V
// 10 - X
// 50 - L
// 100 - C
// 500 - D
// 1000 - M

Console.WriteLine("Введите число от 1 до 3999 для преобразования в римскую цифру:");

int number = Convert.ToInt32(Console.ReadLine());

try
{
    string roman = ToRoman(number);
    Console.WriteLine($"Римская запись: {roman}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

string ToRoman(int number)
{
    if (number < 1 || number > 3999)
    {
        throw new Exception("Число должно быть от 1 до 3999");
    }

    int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

    string result = "";

    for (int i = 0; i < values.Length; i++)
    {
        while (number >= values[i])
        {
            result += symbols[i];
            number -= values[i];
        }
    }

    return result;
}