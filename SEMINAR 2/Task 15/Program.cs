//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write(" Введите цифру, обозначающую день недели: ");
int dayNumb = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumb) {
if (dayNumb == 6 || dayNumb == 7) {
Console.WriteLine("(Этот день выходной) - Да");
}
else if (dayNumb < 1 || dayNumb > 7) {
Console.WriteLine(" Это вообще не день недели");
}
else Console.WriteLine(" (Этот день не выходной) - Нет ");
}
CheckingTheDayOfTheWeek(dayNumb);