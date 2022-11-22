//Напишите программу, которая будет принимать от пользователя позицию (M, N)
//двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
//Если такой позиции в массиве нет, то сообщить об этом пользователю. 
//Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
//Использование методов для заполнения массива обязательно. 
Console.WriteLine("Введите номер строки");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int M = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

if (N > numbers.GetLength(0) || M > numbers.GetLength(1))
{
    Console.WriteLine("Tакой позиции в массиве нет");
}
else
{
    Console.WriteLine($"значение элемента {N} строки и {M} столбца равно {numbers[N-1,M-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
