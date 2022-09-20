// Написать программу, которая выводит третью цифру заданного числа или сообщает , что третьей цифры нет

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if((number > 99) && (number <= 999))
{
    int num1 = number % 10;
    Console.WriteLine(num1);
}
if(number < 99)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    if((number > 999) && (number < 10000))
    {
        int num2 = number / 10;
        Console.WriteLine(num2 % 10);
    }
}



