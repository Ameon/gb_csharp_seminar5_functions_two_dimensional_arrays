// Задача 2:
//  Напишите программу, которая создает двумерный массив 
//  и меняет местами первую и последнюю строку массива.

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
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);

SwapFirstAndLastRows(matrix);
Console.WriteLine("Матрица после замены первой и последней строки:");
PrintMatrix(matrix);

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

void SwapFirstAndLastRows(int[,] matrix)
{
  int lastRowIndex = matrix.GetLength(0) - 1;
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    int temp = matrix[0, i];
    matrix[0, i] = matrix[lastRowIndex, i];
    matrix[lastRowIndex, i] = temp;
  }
}
