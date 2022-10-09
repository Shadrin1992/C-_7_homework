// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = new int[3, 4];
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(1, 11);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

// Функция searchElement ищет элемент по индексу, как в условии задачи.
// Функция searchValue ищет элемент по значения как в примере.
void searchElement(int i, int j)
{
    if (i >= array.GetLength(0) || j >= array.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine(array[i, j]);
    }
}

void searchValue(int value)
{
    bool isFound = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            isFound = array[i,j] == value;
            if (isFound)
            {
                break;
            }
        } 
        if (isFound)
            {
                break;
            }   
    }
    if (isFound)
    {
        Console.WriteLine(value);
    }
    else
    {
        Console.WriteLine("not found");
    }
}
// searchElement(3,2);
searchValue(8);