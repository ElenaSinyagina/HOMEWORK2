// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот
// день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели:");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString);

    if(number == 6 || number == 7)
    {
        Console.WriteLine("Да");
    }
    else if(number >= 1 && number <= 5)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Неправильно введен день недели");
    }
