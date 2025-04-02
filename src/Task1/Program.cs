// Пользователь вводит Имя, Фамилию и год рождения
// Вывсти строку: "Здравствуйте, <Имя> <Фамилия>, вам <N> лет"

Console.WriteLine("Введите ваше Имя и Фамилию, а так же год вашего рождения");

string name = Console.ReadLine();
string surname = Console.ReadLine();
int birthYear = Convert.ToInt32( Console.ReadLine());

int currentYear = DateTime.Now.Year;

int numberYears = currentYear - birthYear;

Console.WriteLine($"Здравствуйте, {name} {surname}, вам {numberYears} лет");