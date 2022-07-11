// // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0


int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}



void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
    Console.WriteLine();
}

int sumElm(int[] array)
{
    int sumEl = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumEl = sumEl + array[i];
    }
    return sumEl;
}



int[] array = FillArray(5, -10, 10);
PrintArray(array);

int sumEl = sumElm(array);
Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {sumEl}");


