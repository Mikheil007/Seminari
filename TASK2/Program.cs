// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число A:");
string inputA = Console.ReadLine();
int A = Convert.ToInt32(inputA);    
Console.Write("Введите число B:");
string inputB = Console.ReadLine();
int B = Convert.ToInt32(inputB);      
Console.Write("Введите число C:");
string inputC = Console.ReadLine();
int C = Convert.ToInt32(inputC);    
if  ((A>B) & (A>C))
{
Console.WriteLine( " max= " +A);
}

if  ((B>A) & (B>C))
{
    Console.WriteLine( " max= " +B);
}
if  ((C>A) & (C>B))
{
    Console.WriteLine( " max= " +C);
}