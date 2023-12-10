// Задача 3:
//  Напишите программу, которая создает прямоугольный 
//  двумерный массив и находит строку с наименьшей суммой элементов.

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

int minSumRowIndex = FindMinSumRow(matrix);
Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {minSumRowIndex}");

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

int FindMinSumRow(int[,] matrix)
{
  int minRow = 0;
  int minSum = int.MaxValue;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum += matrix[i, j];
    }
    if (sum < minSum)
    {
      minSum = sum;
      minRow = i;
    }
  }
  return minRow;
}
