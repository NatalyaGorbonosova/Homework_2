// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());

string ThirdNumber(int number)
{
    if (number >= 100)
    {
        int x1 = number / 100;
        int result = x1 % 10;
        return $"Третья цифра числаЖ: {result}";
    }
    else return "Третьей цифры нет";
}

Console.WriteLine(ThirdNumber(x));