// See https://aka.ms/new-console-template for more information


/*void array_input(int[] array)
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
int[] arr = new int[n];
array_input(arr);
Console.WriteLine($"[{string.Join(",", arr)}]");
Console.WriteLine($"В массиве находятся {even_looker(arr)} четных числа");
even_catcher(arr);
Console.WriteLine($"[{string.Join(",", arr)}]");
even_catcher1(arr, even_looker(arr));
Console.WriteLine($"[{string.Join(",", arr)}]");
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
int n = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[n];
oddArray(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");
finder(arr);
Console.WriteLine(finder(arr));
Console.WriteLine(min_finder(arr));
double total_result = finder(arr) - min_finder(arr);
Console.WriteLine($"{finder(arr)} - {min_finder(arr)} = {total_result}");


