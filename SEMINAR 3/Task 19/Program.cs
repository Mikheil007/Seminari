// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите число");
string? numb = Console.ReadLine();
void CheckingNumber(string numb){
    if (numb[0] == numb[4] || numb[1] == numb[3]){
    Console.WriteLine($"Ваше число:{numb} - палиндром.");
    }

    else 
        Console.WriteLine($"Ваше число: {numb} - не палиндром");
    }
    if (numb!.Length == 5) {
        CheckingNumber(numb);
    }
    else 
    
        Console.WriteLine($"Введите правильное число");