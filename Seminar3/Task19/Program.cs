// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (99999 > number && number < 99999) 
{
    string nomer = Convert.ToString(number);
    string reversenomer = ""; 
    for(int i = nomer.Length - 1; i >= 0; i --)
    reversenomer += nomer [i]; 
    if (nomer == reversenomer)
    {
        Console.WriteLine("Введенная строка является палиндромом.");
    }
    else
    Console.WriteLine("Введенная строка не является палиндромом.");
}
else 
Console.WriteLine("Число не пятизначное");

