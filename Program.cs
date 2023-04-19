// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int a = Prompt("Введите число");

int fnumber(int a)
{
while (a > 999)
{
a /= 10;
}
return a % 10;
}

bool check(int a)
{
if (a < 100)
return false;
else return true;
}

if (check(a) != true)
System.Console.WriteLine("Третьей цифры нет");
else
System.Console.WriteLine($"Третья цифра числа {a} является {fnumber(a)}");