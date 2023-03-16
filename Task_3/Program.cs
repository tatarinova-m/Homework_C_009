// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());


int Num(int m, int n)
{
    if (n < 0 || m < 0)
    {
        Console.WriteLine("Введите неотрицательные числа");
        return 0;
    }
    else if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Num(m - 1, 1);
    else if (m > 0 && n > 0) return Num(m - 1, Num(m, n - 1));
    return Num(m, n);
}

Console.WriteLine(Num(m, n));