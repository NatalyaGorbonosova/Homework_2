// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру 
//этого числа.

Console.WriteLine("Введите трехзначное число");
int x = int.Parse(Console.ReadLine());

int SecondNumber(int number)
{
    int x1 = number / 10;
    int second = x1 % 10;
    return second;
}

Console.WriteLine("Вторая цифра числа: " + SecondNumber(x));