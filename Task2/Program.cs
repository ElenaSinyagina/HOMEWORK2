//Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число и нажмите Enter:");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString);
int number1 = 0;
if(number < 100 && number > -100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if(number < -100)
{
    number1 = number / (-100) % 10;
    Console.WriteLine(number1);
}
else
{
    number1 = number/100 % 10;
    Console.WriteLine(number1);
}