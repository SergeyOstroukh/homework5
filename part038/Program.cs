// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArrayDouble(double[] array)
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

double MaxDigit(double[] array)
{
    int i = 0;
    double max = array[i];
    while (i < array.Length)
    {
        if (array[i] > max) max = array[i];
        i++;

    }
    return max;
}
double MinDigit(double[] array)
{
    int i = 0;
    double min = array[i];
    while (i < array.Length)
    {
        if (array[i] < min) min = array[i];
        i++;

    }
    return min;
}

double DifferenceMinMax(double MaxDigit, double MinDigit)
{
    double result = Math.Round(MaxDigit - MinDigit, 2);
    return result;
}


double[] arr = CreateArrayRndDouble(10, 0, 10);
PrintArrayDouble(arr);
double maximum = MaxDigit(arr);
double minimum = MinDigit(arr);
double diff = DifferenceMinMax(maximum, minimum);
Console.WriteLine($" -> {diff}");

