// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), 
//выводящее это число в консоль вместе с правильным образом изменённым словом "программист",

int n = int.Parse(Console.ReadLine()); // new Random().Next(1, 1001);

string RightEnd(int numberpro)
{
    if ((numberpro % 10 ==1) && (numberpro % 100 != 11)) return ("программист");
    else
    {
       if ((numberpro % 10 == 2 && numberpro % 100 != 12 ) || (numberpro % 10 == 3 &&  numberpro % 100 != 13)
        || (numberpro % 10 == 4 && numberpro % 100 != 14)) return "программиста";   
         else return "программистов";
    }
}
string str = RightEnd(n);
Console.WriteLine($"Сегодня {n} {str}");