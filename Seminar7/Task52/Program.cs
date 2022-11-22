//Запросите от пользователя размерности двумерного массива. 
//Напишите метод для заполнения массива случайными числами.
//Напишите метод для поиска ср. арифметического значения каждого столбца. 
Console.WriteLine("Введите количество строк");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int M = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[N, M];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / N;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}