// See https://aka.ms/new-console-template for more information


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


Console.WriteLine("Введите кол-во элементов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
array_input(arr);
Console.WriteLine($"[{string.Join(",", arr)}]");
Console.WriteLine($"В массиве находятся {even_looker(arr)} четных числа");
even_catcher(arr);
Console.WriteLine($"[{string.Join(",", arr)}]");