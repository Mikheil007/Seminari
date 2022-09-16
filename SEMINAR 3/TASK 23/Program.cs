// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//кубов чисел от 1 до N.

Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.Write($"{numN} -> ");
while (numN >= i)
{
    Console.Write($"{i*i*i} ");
    i = i + 1;
}