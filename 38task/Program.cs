// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] RealNumbers(int size, int min, int max)
{
    double[] arrayNum = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arrayNum[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arrayNum;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ";");
        else Console.Write(arr[i] + "]");
    }
    Console.WriteLine();
}

double maxElements(double[] arrmax)
{
    double max = arrmax[0];
    for (int i = 0; i < arrmax.Length; i++)
    {
        if (max < arrmax[i])
        {
            max = arrmax[i];
        }
    }
    return max;
}

double minElements(double[] arrmin)
{
    double min = arrmin[0];

    for (int i = 0; i < arrmin.Length; i++)
    {
        if (min > arrmin[i])
        {
            min = arrmin[i];
        }
    }
    return min;
}

double mnElements(double[] array)
{
    double max1 = array[0];
    double min1 = array[0];
    double mnEl = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max1 < array[i])
        {
            max1 = array[i];
        }
        if (min1 > array[i])
        {
            min1 = array[i];
        }

        mnEl = max1 - min1;
    }
    return mnEl;
}

double[] array = RealNumbers(10, 1, 10);
PrintArray(array);

double maxEl = maxElements(array);
double minEl = minElements(array);
double mnEl = mnElements(array);

Console.WriteLine($"\nРазница между максимальным {maxEl}   и минимальным {minEl}  элементами: {mnEl}");


