//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

int result;
int enterNum;
Console.Write("Введите любое число: ");
enterNum = Convert.ToInt32(Console.ReadLine());
result = 0;
while (enterNum != 0)
{
result += enterNum % 10;
enterNum /= 10;
}
Console.WriteLine($"Сумма цифр в числе = {result}");