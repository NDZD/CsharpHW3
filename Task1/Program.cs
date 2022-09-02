// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// System.Console.WriteLine("Введите пятизначное число: ");

int InputNumber(int fiveDigit){

while (fiveDigit < 10000 || fiveDigit > 99999)
{
    System.Console.WriteLine("Введено неверное число!");
    System.Console.WriteLine("Введите пятизначное число: ");
    fiveDigit = Convert.ToInt32(Console.ReadLine());
}
return fiveDigit;
}
string CheckPalindrom(int num){
    string str;
if (num / 10000 == num % 10 || (num / 1000 % 10) == (num / 10 % 10) )
{
    str = "Палиндром";
}
else
{
    str = "Не является палиндромом";
}
return str;
}
System.Console.WriteLine("Введите пятизначное число: ");
System.Console.WriteLine(CheckPalindrom(InputNumber(Convert.ToInt32(Console.ReadLine()))));

