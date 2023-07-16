// See https://aka.ms/new-console-template for more information
//Console.Write("Введите число");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[n]; // Здесь мы прописываем длину массива
//for (int i = 0; i < array.Length; i++) // Пробигаемся по миссиву 
//   array[i] = new Random().Next(-10, 11); // Рандомно берет от - 10 до 10
//Console.WriteLine($"{String.Join(",", array)}");



int f(int b)
{
    int n1 = b / 10; // находит первое число 
    int n2 = b % 10; // находит второе число
    if (n1 > n2)
        return n1;
    return n2;
}
int b = new Random().Next(10, 100);// Генерирует цифру от с 10 до 99 
Console.WriteLine(b);
Console.WriteLine(f(b));


int c = new Random().Next(10, 1000); //10 999
Console.WriteLine(c);
int f2(int number)
{
    int c1 = c / 100;
    int c3 = c % 10;
    return
      c1 * 10 + c3;
}

Console.WriteLine(f2(c));