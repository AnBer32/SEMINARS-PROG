// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число N: ");
int number=Convert.ToInt32(Console.ReadLine());

int source = 1;

while (source<number)
{
    if (source % 2==0)


{
     Console.WriteLine(source);
}
source++;
}