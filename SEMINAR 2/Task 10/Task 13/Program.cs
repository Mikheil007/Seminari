// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int anyNumb = Convert.ToInt32(Console.ReadLine());
string anyNumbText = Convert.ToString(anyNumb);
if (anyNumbText.Length > 2){
  Console.WriteLine(" третья цифра - " + anyNumbText[2]);
}
else {
  Console.WriteLine(" третьей цифры нет ");
}