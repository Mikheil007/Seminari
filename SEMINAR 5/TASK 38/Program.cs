// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("введите число, которому будет соответсвовать количество элементов в масиве ");
int size = Convert.ToInt32(Console.ReadLine());
double [] myarray = new double [6];
double max = myarray[0];
double min = myarray[0];
for (int i = 0; i < myarray.Length; i++)
{
   myarray[i] = new Random().NextDouble();
   max = myarray.Max();
   min = myarray.Min();
   }
Console.WriteLine( $"[{string.Join(", ", myarray)}]");
Console.WriteLine();
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine();
Console.WriteLine($"разница между максимальным и минимальным значение: {max - min} ");