// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] array=new int[8];
for(int i=0; i<=7; i++)
{
    Console.Write($"Введите эллемент массива под номером {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<=7;i++)
{
Console.WriteLine(array[i]+ ",");
}

