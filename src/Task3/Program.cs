// Поменять местами знаечние двух переменных, без использования третьей

Console.WriteLine("Введите знаечния для переменных a и b");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

a = a + b;
b = a - b;
a = a - b;

Console.WriteLine($"Значение переменной a = {a}, значение переменной b = {b}");