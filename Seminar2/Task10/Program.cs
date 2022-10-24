// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine ("Введите трехзначное число");

while (true)
{

    string numb = Console.ReadLine ();
    if (numb.Length == 3)
    {
        Console.WriteLine (numb [1]);

    }
    else
    {
        Console.WriteLine ("Ошибка!!! ВВедите трехзначное число");
    }
}
