// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа 
// в промежутке от M до N.

void ShowNums (int m, int n)
{
   if (m < n ) 
   {
    ShowNums (m,n-1);
   }
   Console.Write(n +" ");
}
int M = 1;
int N = 55;
ShowNums(M, N);