// Написать программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

if((number >= 1) && (number < 6))
{
    Console.WriteLine("будни");
}
else
{
    if(number <= 7)
    {
        Console.WriteLine("выходной");
    }
    else
    {
        Console.WriteLine("Введенно не верное число");
    }
}


