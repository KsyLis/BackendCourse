// Определить тип треугольника (остроугольный, тупоугольный, прямоугольный) по длине трех сторон, которые вводит пользователь

// с - бóльшая сторона, тогда:
// если с2 > a2 + b2, то треугольник тупоугольный.
// если с2 = a2 + b2, то треугольник прямоугольный.
// если с2 < a2 + b2, то треугольник остроугольный.

Console.WriteLine("Введите значения для трех сторон теругольника:");

int sideOfTriangleA = Convert.ToInt32(Console.ReadLine());
int sideOfTriangleB = Convert.ToInt32(Console.ReadLine());
int sideOfTriangleC = Convert.ToInt32(Console.ReadLine());

int largestSide = 0;
int side1 = 0;
int side2 = 0;

if ( sideOfTriangleA > sideOfTriangleB && sideOfTriangleA > sideOfTriangleC )
{
    largestSide = sideOfTriangleA;
    side1 = sideOfTriangleB;
    side2 = sideOfTriangleC;
}
else if ( sideOfTriangleB > sideOfTriangleA && sideOfTriangleB > sideOfTriangleC )
{
    largestSide = sideOfTriangleB;
    side1 = sideOfTriangleA;
    side2 = sideOfTriangleC;
}
else
{
    largestSide = sideOfTriangleC;
    side1 = sideOfTriangleA;
    side2 = sideOfTriangleB;
}

if ( Math.Pow(largestSide, 2) > Math.Pow(side1, 2) + Math.Pow(side2, 2) )
{
    Console.WriteLine("Тип треугольника: тупоугольный");
}
else if ( Math.Pow(largestSide, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2) )
{
    Console.WriteLine("Тип треугольника: прямоугольный");
}
else
{
    Console.WriteLine("Тип треугольника: остроугольный");
}