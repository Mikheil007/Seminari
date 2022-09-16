// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
int enterNumA, enterNumB;
int result;
Console.WriteLine("Для формулы A^B");
Console.Write("Введите число A: ");
enterNumA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
enterNumB = Convert.ToInt32(Console.ReadLine());
result = enterNumA;
for (int i = 2; i <= enterNumB; i++)
{
result *= enterNumA;
}
Console.WriteLine($"(число А возведённая в натуральную степень В {enterNumA}^{enterNumB} = {result}");