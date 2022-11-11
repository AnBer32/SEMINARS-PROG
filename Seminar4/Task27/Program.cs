// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32 (Console.ReadLine( ));
int sum = 0;
for (int i = 0; i <= numberA ; i++)
{
    sum=sum+numberA %10;
    numberA/=10;
}
Console.WriteLine(sum);
