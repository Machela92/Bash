// See https://aka.ms/new-console-template for more information
Console.Write("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // Здесь мы прописываем длину массива
for (int i = 0; i < array.Length; i++) // Пробигаемся по миссиву 
    array[i] = new Random().Next(-10, 11); // Рандомно берет от - 10 до 10
Console.WriteLine($"{String.Join(",", array)}");
