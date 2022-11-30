﻿//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int a = InputNumbers("Введите число строк A матрицы: ");
int b = InputNumbers("Введите число столбцов A матрицы (и строк B матрицы): ");
int c = InputNumbers("Введите число столбцов B матрицы: ");

int[,] firstMartrix = new int[a, b];
CreateArray(firstMartrix);
Console.WriteLine($"\n A: ");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[b, c];
CreateArray(secomdMartrix);
Console.WriteLine($"\n B: ");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[a,c];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение A и B матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 30);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}