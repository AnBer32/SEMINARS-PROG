// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
Console.WriteLine("Введите положительное число: a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число: b");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({a}, {b}) = {Akkerman(a, b)}");

int Akkerman(int a, int b)
{
    if (a==0)
        return b+1;
    if (a > 0 && b==0)
        return Akkerman(a-1, 1);
    else
        return Akkerman(a-1, Akkerman(a,b-1));
}
