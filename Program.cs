// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Digits (int number)
{
    int ed = (number % 100);
    int dec = ed % 10;
    int res = (ed - dec) / 10;
    if (res < 0)
    {
        res = -res;
    }
    return res;

}

Console.WriteLine("input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());


if (user_number > 99 && user_number < 1000)
{
    int res = Digits(user_number);
    Console.WriteLine($"Second digit of your number is {res}");
}
else if (user_number < -99 && user_number > -1000)
{
    int res = Digits(user_number);
    Console.WriteLine($"Second digit of your number is {res}");
}
else
{
    Console.WriteLine("Impossible value! ");
}
*/



//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Digits (int number)
{
    if (number < 99)
    {
        Console.WriteLine($"Your number has not a third digit");
    }
    else if (number > 999) {
        while (number > 999)
        {
        number = number / 10;
        }
    int res = number % 10;
    Console.WriteLine($"Third digit of your number is {res}");
    }
    else if (number > 99 && number < 999) {
        int res = number % 10;
        Console.WriteLine($"Third digit of your number is {res}");
    }
    
}

Console.WriteLine("input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
Digits(user_number);




//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckTheDay (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("этот день не выходной");
}

CheckTheDay(dayNumber);

*/