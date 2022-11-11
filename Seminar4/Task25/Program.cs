// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32 (Console.ReadLine( ));
Console.Write("Введите число B, которое будет являться степенью числа А: ");
int numberB = Convert.ToInt32 (Console.ReadLine( ));
int GetResult(int numberA, int numberB)
{
int result = numberA;
for (int i = 1; i < numberB ; i++)
{
       result = result * numberA;
    }
     return result;
}
int result = GetResult(numberA, numberB);
Console.WriteLine(result);

