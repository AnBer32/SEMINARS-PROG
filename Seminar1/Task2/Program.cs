//Напишите программу, которая на вход принимает два числа и выдает,какое число больше, а какое меньше.

Console.WriteLine("ВВедите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

int max=x;
if(x>max) max=x;
if(y>max) max=y;

Console.WriteLine($"Максимальное число равно: {max}");









