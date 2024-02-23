// Напишите программу, которая принимает на вход
// координаты точки(X и Y),причем X<> 0 и Y <> 0 и
// выдает номер координатной плоскости, в которой
// находится эта точка.

// 2, 3 => 1
// -5, 2 => 2


Console.WriteLine("Введите координату X");
int numX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y");
int numY = Convert.ToInt32(Console.ReadLine());

if (numX == 0 || numY == 0)
{
    Console.WriteLine("Вводите ненулевые координаты!");
    return;
}
if (numX > 0 && numY > 0)
{
    Console.Write($"{numX}, {numY} => 1");

}
else if (numX < 0 && numY > 0)
{
    Console.Write($"{numX}, {numY} => 2");

}
else if (numX < 0 && numY < 0)
{
    Console.Write($"{numX}, {numY} => 3");
}
else if (numX > 0 && numY < 0)
{
    Console.Write($"{numX}, {numY} => 4");
}



