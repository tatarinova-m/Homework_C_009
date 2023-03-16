// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int m = Convert.ToInt32(Console.ReadLine());

int Num(int n, int m)
{
    if (m == n) return n;
    else return n + Num(n + 1, m);
}

Console.WriteLine(Num(n, m));