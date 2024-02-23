// Напишите программу, которая принимает на вход
// целое число из отрезка [10,99] и показывает 
// наибольшую цифру числа.
// 40 => 4
// 96 => 9



Console.WriteLine("Введите число от 10 до 99");
int numX = Convert.ToInt32(Console.ReadLine());

int firstDigit = numX / 10;
int lastDigit = numX % 10;

if (10 <= numX && numX <= 99)
{
    string num = firstDigit >= lastDigit ? ($"{firstDigit}") : ($"{lastDigit}");

    Console.Write($"{numX} => {num}");
}
else
{
    Console.Write("Некорректный ввод!");
}