// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите трёхзначное число: ");
        int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
        string stringNumber = Convert.ToString(threeDigitNumber);
        Console.WriteLine("Вторая цифра этого числа " + stringNumber[1]);
    }
}
