// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите размеры массива");
Console.WriteLine("Введите A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B");
int B = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[A, B];
 for (int i = 0; i < array.GetLength(0); i++) 
{
for (int j = 0; j < array.GetLength(1); j++)
array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 for (int i = 0; i < array.GetLength(0); i++) 
{
for (int j = 0; j < array.GetLength(1); j++)
Console.Write(array[i,j] + "\t  ");
Console.WriteLine();
}
for (int i = 0; i < B; i++) 
{
int srAr = 0;
for (int t = 0; t < A; t++)
{
srAr += array[t, i];
}
Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr/3}");
}