// See https://aka.ms/new-console-template for more information

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void array_input(int[] array)
{

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);

}

int even_looker(int[] array)
{
    int evenCounter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        {
            evenCounter++;

        }
    return evenCounter;
}

string even_catcher(int[] array) // Метод превращает нечетные в нули, тем самым показывает все четные числа в массиве.
{
    int x = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 1)
        {
            array[i] = x;
        }
    return $"{x}";
}

string even_catcher1(int[] array, int length)
{
    int[] newArray = new int[length];
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 1)
        {
            array[i] = newArray[i];
        }
    return $"{newArray}";
}
Console.WriteLine("Введите кол-во элементов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr1 = new int[n];
array_input(arr1);
Console.WriteLine($"[{string.Join(",", arr1)}]");
Console.WriteLine($"В массиве находятся {even_looker(arr1)} четных числа");
even_catcher(arr1);
Console.WriteLine($"[{string.Join(",", arr1)}]");
even_catcher1(arr1, even_looker(arr1));
Console.WriteLine($"[{string.Join(",", arr1)}]");


/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
void oddArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
}

double finder(double[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[max])
        {
            array[max] = array[i];
        }
    }
    return array[max];
}

double min_finder(double[] array)
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[min])
            array[min] = array[i];
    }
    return array[min];
}
Console.WriteLine("Введите кол-во элементов в массиве");
int t = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[t];
oddArray(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");
finder(arr);
Console.WriteLine(finder(arr));
Console.WriteLine(min_finder(arr));
double total_result = Math.Round(finder(arr) - min_finder(arr), 2);
Console.WriteLine($"{finder(arr)} - {min_finder(arr)} = {total_result}");


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine("Введите число элементов в  массиве");
int a = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[a];

void array_filler(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(10, 1000);
}

int oddIndexMath(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = array[i] + sum;
    }
    return sum;
}


void oddIndexshow(int[] array)
{

    for (int i = 1; i < array.Length; i += 2)
    {

        Console.WriteLine($"нечетный индекс = {i} числа {array[i]}");
    }
}
array_filler(array1);
Console.WriteLine($"[{string.Join(",", array1)}]");
oddIndexshow(array1);
Console.WriteLine($" Сумма  нечетных инедксов  = {oddIndexMath(array1)}");
