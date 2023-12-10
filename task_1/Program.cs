// Задача 1:
//  Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента 
//  или же указание, что такого элемента нет.

Console.Write("Введите размеры матрицы: ");
string? input = Console.ReadLine()?.Trim();

if (input == null)
{
  Console.WriteLine("Ошибка: не был получен ввод.");
  return;
}

int[] size = input.Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);

Console.Write("Введите индексы элемента (строка и столбец): ");
string? inputIndexes = Console.ReadLine()?.Trim();

if (inputIndexes == null)
{
  Console.WriteLine("Ошибка: не был получен ввод.");
  return;
}

int[] indexes = inputIndexes.Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine(GetElementAt(matrix, indexes[0], indexes[1]));

void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
    for (int j = 0; j < matrix.GetLength(1); j++)
      matrix[i, j] = new Random().Next(0, 11);
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      Console.Write(matrix[i, j] + "\t");
    Console.WriteLine();
  }
}

string GetElementAt(int[,] array, int row, int col)
{
  if (row >= 0 && row < array.GetLength(0)
    && col >= 0 && col < array.GetLength(1)
  )
  {
    return array[row, col].ToString();
  }
  else
  {
    return "Элемента с такими индексами нет.";
  }
}
