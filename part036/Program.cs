// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int SumElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)         // 0 1 2 3 4 5 6 7 8 9
    {                                              // 1 2 3 4 5 6 7 8 9 10
        if (i % 2 == 1)
            sum = sum + array[i];
    }
    return sum;
}

int[] arr = CreateArray(10, -5, 5);
PrintArray(arr);
int sumElements = SumElements(arr);
Console.WriteLine($" -> {SumElements(arr)}");