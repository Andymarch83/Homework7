/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Random random = new Random();
int[,] matrix = new int[random.Next(3, 5), random.Next(3, 5)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random.Next(1, 10);
        Console.Write($"{matrix[i, j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write($"Среднее арифметическое каждого столбца: ");

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    Console.Write($"{Math.Round(sum / matrix.GetLength(0), 2)}; ");
}
Console.ReadLine();
