// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine());

void DayWeek(int daynumber)
{
    if ((daynumber > 0) && (daynumber < 8)) 
    {
        if (daynumber < 6) Console.WriteLine("Нет, это рабочий день");
        else Console.WriteLine("Да, это выходной!!!");
    }
    else Console.WriteLine("Введите цифру от 1 до 7");
}

DayWeek(x);