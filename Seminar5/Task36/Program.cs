// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Задайте размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[]numbers=new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int count = 0;

for(int i=0; i<numbers.Length; i++)

{
    if (i % 2 == 0)
    {
        count += numbers[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {count}");

void FillArrayRandomNumbers(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-i,+i);
    }
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
  
}
