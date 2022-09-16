// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число x");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x % 10;
int x2 = x / 10 % 10;
int x4 = x / 1000 % 10;
int x5 = x / 10000;
if (x1 == x5 & x2 == x4)
{
Console.WriteLine("Введенное число полиндром");
}
else Console.WriteLine("Введенное число, не полиндром");