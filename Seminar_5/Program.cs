// See https://aka.ms/new-console-template for more information


void setArray(int[] array) // функция для заполнения  массива 
{
    for (int i = 0; i < array.Length; i++) // пробежка по массиву 

        array[i] = new Random().Next(-9, 10);  // При пробежке массива заполняем его случайными числами 

}

void releasArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= (-1);
    }
}

void sum_index(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] = 1)
    }
}
Console.WriteLine("Введите  элементы в массив");
int num = Convert.ToInt32(Console.ReadLine()); // вводим число 
int[] arr = new int[num]; // Это число  передает какой  длины будет массив
setArray(arr); // вызов функции 
Console.WriteLine($"[{string.Join(", ", arr)}]"); // вывод массива на  экран 
releasArray(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");