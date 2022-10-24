// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите порядковый номер дня недели от 1 до 7:");
int namber = Convert.ToInt32(Console.ReadLine());
if(namber >= 1  || namber < 8)
{
   if(namber == 6 || namber == 7)
{
    Console.WriteLine("ДА, выходной.");
}
else
{
    Console.WriteLine("Не выходной.");
} 
}
else
{
    Console.WriteLine("Ошибка.");
}

