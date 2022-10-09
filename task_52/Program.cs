// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[3, 4];
Random rand = new Random();
int summ = 0;
//var avg = 0.0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(1, 11);
        Console.Write($"{array[i, j]} ");        
    }
    Console.WriteLine();    
}

Console.WriteLine("Среднее арифметическое для каждого столбца:"); 
for (int i = 0; i < array.GetLength(1); i++)
{
    summ = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        summ = summ + array[j, i];        
    }
    double avg = Convert.ToDouble(summ) / array.GetLength(0);
    Console.Write($"{avg:F2} ");
}

