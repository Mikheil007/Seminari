// Task 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("This program find array element by the entered indexes. ");
int numberRow = EnterUserData(" Введите количество строк: ");
int numberCol = EnterUserData(" Введите количество стольбцов: ");
int lowerLim = EnterUserData(" Введите нижний предел случайного диапазона: ");
int upperLim = EnterUserData(" Введите верхний предел случайного диапазона: ");
int precision = EnterUserData(" Введите для чисел: ");
double[,] randomArray = new double[numberRow, numberCol];
FillArray(randomArray, numberRow, numberCol, lowerLim, upperLim, precision);
PrintArray(randomArray);
int indexRow = EnterUserData(" Введите индекс строки: ") - 1;
int indexCol = EnterUserData(" Введите индекс столбца: ") - 1;
if (indexRow < 0 ||
indexRow > randomArray.GetLength(0) ||
indexCol < 0 ||
indexCol > randomArray.GetLength(1))
{
Console.WriteLine("Это не элемент массива с введенными индексами. Попробуйте еще раз!");
}
else
{
Console.WriteLine(randomArray[indexRow, indexCol]);
}

double [,] FillArray(double[,] array, int numberRow, int numberCol, int lowerLim, int upperLim, int precision)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
for (int j = 0; j < array.GetLength(1); j++)
        {
double randomNum = new Random().NextDouble() * (upperLim - lowerLim);
array[i, j] = Math.Round(randomNum, precision);
        }
    }
return array;
}
void PrintArray(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
for (int j = 0; j < array.GetLength(1); j++)
        {
Console.Write(array[i, j] + " ");
        }
Console.WriteLine();
    }
}
int EnterUserData(string nameUserData)
{
Console.Write($"{nameUserData}");
return Convert.ToInt32(Console.ReadLine());
}