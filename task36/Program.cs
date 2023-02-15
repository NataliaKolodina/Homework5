// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();

int length = InputNumber("Введите количество элементов в массиве: ");
int min = InputNumber("Введите минимальное значение в массиве: ");
int max = InputNumber("Введите максимальное значение в массиве: ");
int[] arr = GetArray(length, min, max);

Console.Write("[");
PrintArray(arr);
Console.Write($"] -> {Sum(arr)}");


int InputNumber(string message)  
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int Sum(int [] array)
{
   int sum = 0;
   for (int i = 0; i < array.Length; i++) 
   {
    if (i%2>0)
    {
        sum += array[i];
    }
   }
    return sum;
}