// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите число и нажмите Enter:");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString);

int number1 = number / 10;
int result = number1 % 10;
if(result < 0)
{
    result = result * (-1);
    Console.WriteLine("Вторая цифра числа: " + result);
}
else 
{
    Console.WriteLine("Вторая цифра числа: " + result);
}