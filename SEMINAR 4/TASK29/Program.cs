//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int enterNum;
Console.WriteLine("Будет создан массив длиной A в диапвзоне 0-A");
Console.Write("Введите любое число (A): "); enterNum = Convert.ToInt32(Console.ReadLine());
int[] array = new int[enterNum];
for (int i = 0; i < enterNum; i++)
{
array[i] = new Random().Next(enterNum + 1);
Console.Write(array[i] + "; ");
}
Console.WriteLine();