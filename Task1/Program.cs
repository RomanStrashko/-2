// Написать программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int num1 = number / 10;
int num2 = num1 % 10;
Console.WriteLine(num2);
