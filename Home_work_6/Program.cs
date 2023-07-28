// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите отрицательные или положительные числа в миссив  между какждым символом делайте 1 пробел.");

int[] negative_array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"[{string.Join(",", negative_array)}]");


int negative_number_counter(int[] array1)
{
    int neg_counter = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] < 0)
        {
            neg_counter++;
        }

    }
    return neg_counter;
}

Console.WriteLine($" Отрицательных числе введнных вами в массиве  равно {negative_number_counter(negative_array)}");


Console.WriteLine("Введите переменную b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = Math.Round((-b2 + b1) / (-k1 + k2), 2);
double y = Math.Round((k2 * x + b2), 2);

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");