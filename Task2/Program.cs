//Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число и нажмите Enter:");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString);

string str = number.ToString();
int[] array = new int[str.Length];
for( int index = 0; index < str.Length; index++)
{
    array[index] = int.Parse(str[index].ToString());
}
if (number > 100)
{
    Console.WriteLine("Третья цифра: " + array[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}
